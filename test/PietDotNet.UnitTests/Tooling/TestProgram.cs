using System.Drawing;

namespace PietDotNet.Tests.Tooling
{
    public class TestProgram
    {
        private TestProgram() { }

        public static Program Load(string path)
        {
            using (var stream = typeof(TestProgram).Assembly.GetManifestResourceStream("PietDotNet.Tests.Programs." + path))
            {
                return Program.From(stream);
            }
        }
    }
}
