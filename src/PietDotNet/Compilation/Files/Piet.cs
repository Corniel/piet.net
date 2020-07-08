using PietDotNet;
using PietDotNet.IO;

namespace Piet
{
    public class Program
    {
        public static void Main()
        {
            var program = Binary.Load(typeof(Program).Assembly.GetManifestResourceStream("binary.piet"));
            var console = new PietConsole();
            program.Run(console, console);
        }
    }
}
