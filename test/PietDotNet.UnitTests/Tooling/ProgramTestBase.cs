namespace PietDotNet.Tests.Tooling
{
    public abstract class ProgramTestBase
    {
        protected ProgramTestBase()
        {
            IO = new TestIO();
            Logger = new UnitTestLogger();
            var program = Load(Location);
            Interpreter = new Interpreter(program, IO, Logger);
        }

        public TestIO IO { get; }
        public UnitTestLogger Logger { get; }
        public Interpreter Interpreter { get; }
        protected abstract string Location { get; }

        public static Program Load(string path)
        {
            using (var stream = typeof(ProgramTestBase).Assembly.GetManifestResourceStream("PietDotNet.Tests.Programs." + path))
            {
                return Program.From(stream);
            }
        }
    }
}
