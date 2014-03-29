using System.IO;
using NUnit.Framework;
using PredictiveCoder;

namespace Tests
{
    [TestFixture]
    public class BitReaderAndWriterFixture
    {
        [Test]
        public void CanReadAByteBitByBit()
        {
            const string path = "text.txt";
            File.WriteAllBytes(path, new byte[] { 1 });

            var reader = new BitReader(path);
            First7BitsAre0(reader);
            LastBitIs1(reader);
            reader.closeFile();

            File.Delete(path);
        }

        private static void First7BitsAre0(BitReader reader)
        {
            for (int i = 0; i < 7; i++)
            {
                Assert.AreEqual(0, reader.readBit());
            }
        }

        private static void LastBitIs1(BitReader reader)
        {
            Assert.AreEqual(1, reader.readBit());
        }
    }
}
