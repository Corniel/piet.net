using Microsoft.Extensions.Logging;
using PietDotNet.Communication;
using PietDotNet.Logging;
using System;
using System.IO;

namespace PietDotNet
{
    public static class Piet
    {
        private static readonly InOut ConsoleIO = new ConsoleIO();

        public static void Main(params string[] args)
        {
            if (args is null || args.Length == 0)
            {
                Console.WriteLine("Specify a program.");
                return;
            }
            var file = new FileInfo(args[0]);
            
            if(!file.Exists)
            {
                Console.WriteLine($"Program {file.FullName} does not exist.");
                return;
            }

            var logLevel = args.Length > 1 && Enum.TryParse<LogLevel>(args[1], true, out var parsed)
                ? parsed 
                : LogLevel.Error;

            var program = Program.From(file);
            var logger = new ConsoleLogger(logLevel);

            program.Run(ConsoleIO, logger);
        }
    }
}
