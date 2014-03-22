using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictiveCoder
{
    class Decoder
    {
        public const int imageHeight = 256;
        public const int imageWidth = 256;
        public byte[,] decMatrix, predMatrix;
        public int[,] predErrMatrixQ, predErrMatrixDQ, errorMatrix;
        private byte[] antet;
        public int k, predMethod;
        public Decoder()
        {
            int i, j;
            predMatrix = new byte[imageHeight, imageWidth];
            predErrMatrixQ = new int[imageHeight, imageWidth];
            predErrMatrixDQ = new int[imageHeight, imageWidth];
            decMatrix = new byte[imageHeight, imageWidth];
            errorMatrix = new int[imageHeight, imageWidth];
            antet = new byte[1078];
            for (i = 0; i < 256; i++)
                for (j = 0; j < 256; j++)
                {
                    predErrMatrixQ[i, j] = 0;
                    predErrMatrixDQ[i, j] = 0;
                    decMatrix[i, j] = 0;
                    predErrMatrixQ[i, j] = 0;
                }
        }

        public void loadImage(String path)
        {
            int writeFormat, i, j, line, index;
            BitReader reader = new BitReader(path);
            predMethod = reader.readNBits(4);
            k = reader.readNBits(8);
            writeFormat = reader.readBit();
            for (i = 0; i < 1078; i++)
                antet[i] = (byte)reader.readNBits(8);
            if (writeFormat == 0)
            {
                for (i = 0; i < 256; i++)
                    for (j = 0; j < 256; j++)
                    {
                        predErrMatrixQ[i, j] = reader.readNBits(9);
                        // for negative values
                        if (predErrMatrixQ[i, j] > 255)
                            predErrMatrixQ[i, j] -= 512;
                    }
            }
            else if (writeFormat == 1)
            {
                for (i = 0; i < 256; i++)
                    for (j = 0; j < 256; j++)
                    {
                        line = 0;
                        while (reader.readBit() == 1) line++;
                        index = reader.readNBits(line);
                        if (index < Math.Pow(2, line - 1))
                            predErrMatrixQ[i, j] = (int)(index - (Math.Pow(2, line) - 1));
                        else
                            predErrMatrixQ[i, j] = index;
                    }
            }
            reader.closeFile();

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

        public void decode()
        {
            int i, j, decValue;
            for (i = 0; i < imageHeight; i++)
                for (j = 0; j < imageWidth; j++)
                {
                    predErrMatrixDQ[i, j] = predErrMatrixQ[i, j] * (2 * k + 1);
                    predMatrix[i, j] = prediction(i, j);
                    decValue = predMatrix[i, j] + predErrMatrixDQ[i, j];
                    if (decValue < 0) decValue = 0;
                    else if (decValue > 255) decValue = 255;
                    decMatrix[i, j] = (byte)decValue;
                }
        }

        public void saveImage(string path)
        {
            BitWriter writer = new BitWriter(path);

            for (int i = 0; i < 1078; i++) writer.writeNBits(antet[i], 8);
            for (int i = 0; i < 256; i++)
                for (int j = 0; j < 256; j++)
                    writer.writeNBits(decMatrix[i, j], 8);
            writer.closeFile();
        }
    }
}
