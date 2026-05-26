using Piet.Interpreting;
using Piet.Programs;
using Piet.Runtime;
using System.IO;

namespace Benchmarks;

public static class Runner
{
    public static IReadOnlyList<object> Run(RunnerContext ctx)
    {
        ctx.Reset();
        ctx.Program.Run(new Context
        {
            Logger = ctx.Logger,
            State = State.New(ctx),
            MaxRuns = int.MaxValue,
        });
        return ctx.Output;
    }

    extension(Stream stream)
    {
        public RunnerContext Ctx(params int[] ints) => new()
        {
            Program = stream.Program(),
            Ints = [.. ints],
        };
    }
}
