using PietDotNet;
using PietDotNet.IO;
using PietDotNet.Logging;

namespace Piet
{
    internal class Program
    {
        private static readonly InOut ConsoleIO = new ConsoleIO();

        public static void Main()
        {
            var program = Binary.Load(typeof(Program).Assembly.GetManifestResourceStream("binary.piet"));
            var logger = new ConsoleLogger(Microsoft.Extensions.Logging.LogLevel.Error);
            program.Run(ConsoleIO, logger);
        }
    }
}
