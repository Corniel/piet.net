using Piet.Interpreting;
using Piet.Syntax;

namespace Specs.Tooling;

internal static class Runner
{
    internal static RunResult RunWithInput(Program program, params object[] input)
    {
        var logger = new UnitTestLogger();
        var io = new TestIO();

        foreach (var value in input)
        {
            if (value is char ch) io.InChrs.Enqueue(ch);
            else if (value is int i) io.InInts.Enqueue(i);
            else if (value is long l) io.InInts.Enqueue(l);
            else throw new ArgumentException($"{value} is invalid input");
        }

        var context = new Context
        {
            State = Piet.Runtime.State.New(io),
            MaxRuns = short.MaxValue,
            Logger = logger,
        };

        program.Run(context);

        return new RunResult(io, logger);
    }

    internal static RunResult Run(Program program)
        => RunWithInput(program);
}
