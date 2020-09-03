using System;
using System.Collections.Generic;
using System.Text;

namespace String_to_Unicode_and_binary_translator
{
    class CodePrinter
    {
        public Tuple<byte[], string> Printer32(string words)
        {
            byte[] binaries = Encoding.UTF32.GetBytes(words);
            string binarieswords = BitConverter.ToString(binaries);
            return Tuple.Create(binaries, binarieswords);
        }
        public Tuple<byte[], string> Printer16(string words)
        {
            byte[] binaries = Encoding.Unicode.GetBytes(words);
            string binarieswords = BitConverter.ToString(binaries);
            return Tuple.Create(binaries, binarieswords);
        }
        public Tuple<byte[], string> Printer8(string words)
        {
            byte[] binaries = Encoding.UTF8.GetBytes(words);
            string binarieswords = BitConverter.ToString(binaries);
            return Tuple.Create(binaries, binarieswords);
        }
        public Tuple<byte[], string> Printer7(string words)
        {
            byte[] binaries = Encoding.UTF7.GetBytes(words);
            string binarieswords = BitConverter.ToString(binaries);
            return Tuple.Create(binaries, binarieswords);
        }
    }
}
