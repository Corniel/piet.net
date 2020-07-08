using PietDotNet.IO;
using PietDotNet.Logging;
using System;
using System.Text;

namespace PietDotNet
{
    internal class PietConsole : InOut, Logger
    {
        public PietConsole(LogLevel minLevel = LogLevel.Error)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            MinLevel = minLevel;
        }

        private LogLevel MinLevel { get; }

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

        public void Log(LogLevel level, string message)
        {
            if (level < MinLevel) return;

            Console.Error.WriteLine($"{level} {message}");
        }
    }
}
