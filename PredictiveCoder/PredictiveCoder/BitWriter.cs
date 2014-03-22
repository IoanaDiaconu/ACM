using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictiveCoder
{
    class BitWriter
    {
        public string fileName;
        private FileStream stream;
        private byte buffer;
        public int writtenBitsCounter;

        public BitWriter(string path)
        {
            fileName = path;
            stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            writtenBitsCounter = 0;
        }

        public void writeBit(byte bit)
        {
            buffer = (byte)(buffer << 1);
            buffer |= (byte)(bit & 0x01);
            writtenBitsCounter++;
            if (writtenBitsCounter % 8 == 0)
            {
                stream.WriteByte(buffer);
                buffer = 0;
            }
        }

        public void writeNBits(int value, int number)
        {
            int i;
            for (i = number - 1; i >= 0; i--)
                writeBit((byte)(value >> i));
        }

        public void closeFile()
        {
            stream.Close();
        }

    }
}
