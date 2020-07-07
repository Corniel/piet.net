using System;

namespace PietDotNet.Tests.Tooling
{
    internal static class Runner
    {
        internal static RunResult RunWithInput(string path, params object[] input)
        {
            var io = new TestIO();
            foreach(var value in input)
            {
                if (value is char ch) io.InChrs.Enqueue(ch);
                else if (value is int i) io.InInts.Enqueue(i);
                else if (value is long l) io.InInts.Enqueue(l);
                else throw new ArgumentException($"{value} is invalid input");
            }
            return Run(path, io: io);
        
        }

        internal static RunResult Run(string path, int codelSize = 1, int maxRuns = int.MaxValue, TestIO io = null)
        {
            var program = Load(path, codelSize);
            var logger = new UnitTestLogger();
            io ??= new TestIO();
            program.Run(io, logger, maxRuns);

            return new RunResult(io, logger);
        }

        internal static Program Load(string path, int codelsize = 1)
        {
            using var stream = typeof(Runner).Assembly.GetManifestResourceStream("PietDotNet.Tests.Programs." + path);
            return Program.From(stream, codelsize);
        }
    }
}
