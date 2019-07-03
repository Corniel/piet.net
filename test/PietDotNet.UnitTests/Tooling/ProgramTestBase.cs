namespace PietDotNet.Tests.Tooling
{
    public abstract class ProgramTestBase
    {
        protected ProgramTestBase()
        {
            IO = new TestIO();
            Logger = new UnitTestLogger();
            var program = Load(Location, CodelSize);
            Interpreter = new Interpreter(program, IO, Logger, 10000);
        }

        public TestIO IO { get; }
        public UnitTestLogger Logger { get; }
        public Interpreter Interpreter { get; }
        protected abstract string Location { get; }
        public virtual int CodelSize { get; } = 1;

        public static Program Load(string path, int codelsize = 1)
        {
            using (var stream = typeof(ProgramTestBase).Assembly.GetManifestResourceStream("PietDotNet.Tests.Programs." + path))
            {
                return Program.From(stream, codelsize);
            }
        }
    }
}
