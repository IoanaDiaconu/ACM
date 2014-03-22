using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictiveCoder
{
    class Coder
    {
        public const int imageHeight = 256;
        public const int imageWidth = 256;
        public byte[,] origImage;
        private byte[,] predMatrix, predMatrixDec, decMatrix;
        public int[,] predErrMatrix, predErrMatrixQ, predErrMatrixDQ, errorMatrix;
        private byte[] antet;
        public int k, predMethod;
        public Coder()
        {
            int i, j;
            k = 1;
            origImage = new byte[imageHeight, imageWidth];
            predMatrix = new byte[imageHeight, imageWidth];
            predMatrixDec = new byte[imageHeight, imageWidth];
            predErrMatrix = new int[imageHeight, imageWidth];
            predErrMatrixQ = new int[imageHeight, imageWidth];
            predErrMatrixDQ = new int[imageHeight, imageWidth];
            decMatrix = new byte[imageHeight, imageWidth];
            errorMatrix = new int[imageHeight, imageWidth];
            antet = new byte[1078];
            for (i = 0; i < 256; i++)
                for (j = 0; j < 256; j++)
                {
                    predMatrix[i, j] = 0;
                }
        }
        public void readOrigImage(string imagePath)
        {
            byte val;
            BinaryReader br = new BinaryReader(File.Open(imagePath, FileMode.Open));
            for (int i = 0; i < 1078; i++)
                antet[i] = br.ReadByte();
            for (int i = 0; i < imageHeight; i++)
                for (int j = 0; j < imageWidth; j++)
                {
                    val = br.ReadByte();
                    origImage[i, j] = val;
                }
            br.Close();
        }

        public byte prediction(int i, int j)
        {
            byte A, B, C;
            int pred;
            if (predMethod == 0) return 128;
            else if (i == 0 && j == 0) return 128;
            else if (i == 0 && j != 0) return decMatrix[i, j - 1];
            else if (i != 0 && j == 0) return decMatrix[i - 1, j];
            else
            {
                A = decMatrix[i, j - 1];
                B = decMatrix[i - 1, j];
                C = decMatrix[i - 1, j - 1];
                pred = 0;
                switch (predMethod)
                {
                    case 1: pred = A; break;
                    case 2: pred = B; break;
                    case 3: pred = C; break;
                    case 4: pred = A + B - C; break;
                    case 5: pred = A + (B - C) / 2; break;
                    case 6: pred = B + (A - C) / 2; break;
                    case 7: pred = (A + B) / 2; break;
                    case 8:
                        if (C >= Math.Max(A, B)) pred = Math.Min(A, B);
                        else if (C <= Math.Min(A, B)) pred = Math.Max(A, B);
                        else pred = A + B - C;
                        break;
                }
                if (pred < 0) return 0;
                else if (pred > 255) return 255;
                else return (byte)pred;
            }
        }

        public void code()
        {
            int i, j, decValue;
            for (i = 0; i < imageHeight; i++)
                for (j = 0; j < imageWidth; j++)
                {
                    predMatrix[i, j] = prediction(i, j);
                    predErrMatrix[i, j] = (int)(origImage[i, j] - predMatrix[i, j]);
                    predErrMatrixQ[i, j] = (int)Math.Floor((double)(predErrMatrix[i, j] + k) / (double)(2.0 * k + 1));
                    predErrMatrixDQ[i, j] = predErrMatrixQ[i, j] * (2 * k + 1);
                    predMatrixDec[i, j] = predMatrix[i, j];
                    decValue = predMatrixDec[i, j] + predErrMatrixDQ[i, j];
                    if (decValue < 0) decValue = 0;
                    else if (decValue > 255) decValue = 255;
                    decMatrix[i, j] = (byte)decValue;
                    errorMatrix[i, j] = (int)(origImage[i, j] - decMatrix[i, j]);
                }
        }

        public void writeResultsFile(String path, int predMethod, int writeFormat)
        {
            int i, j, lineIndex, m;
            BitWriter writer = new BitWriter(path);
            writer.writeNBits(predMethod, 4);
            writer.writeNBits(k, 8);
            writer.writeBit((byte)writeFormat);
            for (i = 0; i < 1078; i++)
                writer.writeNBits(antet[i], 8);
            // fixed 
            if (writeFormat == 0)
            {
                for (i = 0; i < 256; i++)
                    for (j = 0; j < 256; j++)
                    {
                        writer.writeNBits(predErrMatrixQ[i, j], 9);
                    }
            }
            // table
            else if (writeFormat == 1)
            {
                for (i = 0; i < 256; i++)
                    for (j = 0; j < 256; j++)
                    {
                        if (j == 106)
                        {
                            m = 0;
                        }
                        lineIndex = 0;
                        if (predErrMatrixQ[i, j] != 0)
                        {
                            lineIndex = (int)Math.Floor(Math.Log(Math.Abs(predErrMatrixQ[i, j]), 2) + 1); 
                            for (m = 0; m < lineIndex; m++)
                                writer.writeBit(1);
                        }
                        writer.writeBit(0);

                        int index = predErrMatrixQ[i, j];
                        if (index < 0)
                            index = predErrMatrixQ[i, j] + (int)Math.Pow(2, lineIndex) - 1;
                        writer.writeNBits(index, lineIndex);
                    }
            }
            // if there are some leftover bits that haven't been written
            if (writer.writtenBitsCounter % 8 != 0)
                writer.writeNBits(0, 8 - (writer.writtenBitsCounter % 8));
            writer.closeFile();
        }


    }
}
