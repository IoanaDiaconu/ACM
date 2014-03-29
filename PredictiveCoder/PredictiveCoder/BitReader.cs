using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictiveCoder
{
    public class BitReader
    {
        private string fileName;
        private FileStream stream;
        private byte buffer;
        private int readBitsCounter;
        public BitReader(string path)
        {
            fileName = path;
            stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            readBitsCounter = 0;
        }

        public byte readBit()
        {
            byte readBit;
            int pos;
            pos = readBitsCounter % 8;
            if (pos == 0)
                buffer = (byte)stream.ReadByte();
            readBit = (byte)((buffer >> (7 - pos)) & 0x01);
            readBitsCounter++;
            return readBit;
        }

        public int readNBits(int number)
        {
            int readData = 0, i;
            for (i = 0; i < number; i++)
                readData = (readData << 1) | readBit();
            return readData;
        }

        public void closeFile()
        {
            stream.Close();
        }
    }
}
