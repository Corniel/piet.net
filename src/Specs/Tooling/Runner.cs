using PietDotNet.Drawing;
using System.IO;

namespace Specs.Tooling;

internal static class Runner
{
    internal static RunResult RunWithInput(Program program, params object[] input)
    {
        var io = new TestIO();
        foreach (var value in input)
        {
            if (value is char ch) io.InChrs.Enqueue(ch);
            else if (value is int i) io.InInts.Enqueue(i);
            else if (value is long l) io.InInts.Enqueue(l);
            else throw new ArgumentException($"{value} is invalid input");
        }
        return Run(program, io: io);
    }

    internal static RunResult Run(Program program, int maxRuns = int.MaxValue, TestIO? io = null)
    {
        var logger = new UnitTestLogger();
        io ??= new TestIO();
        program.Run(io, logger, maxRuns);

        return new RunResult(io, logger);
    }

    internal static Program Load(string path, int codelsize = 1)
    {
        using var stream = typeof(Runner).Assembly
            .GetManifestResourceStream("Specs.Programs." + path)
            ?? throw new FileNotFoundException(path);

        return Bitmapping.Load(stream, codelsize);
    }
}
