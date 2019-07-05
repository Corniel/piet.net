using System;
using System.Text;

namespace PietDotNet
{
    public class ConsoleInOut : IInOut
    {
        public ConsoleInOut()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        }

        public char? InChr()
        {
            var input = Console.Read();
            return input > -1
                ? (char)input
                : (char?)null;
        }

        public long? InInt()
        {
            var input = Console.ReadLine();
            return long.TryParse(input, out var @in)
                ? @in
                : (long?)null;
        }

        public void Out(long n) => Console.Write(n);

        public void Out(char c) => Console.Write(c);
    }
}
