using Piet.Interpreting;
using Piet.Runtime;
using Piet.Syntax;

namespace Specs.Tooling;

internal static class Runner
{
    internal static RunResult Run(Func<State, bool> program, params object[] input)
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

        program(State.New(io));

        return new RunResult(io, logger);
    }

    internal static RunResult Run(Program program, params object[] input)
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
            State = State.New(io),
            MaxRuns = short.MaxValue,
            Logger = logger,
        };

        program.Run(context);

        return new RunResult(io, logger);
    }
}
