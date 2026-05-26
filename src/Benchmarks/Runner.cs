using Piet.Interpreting;
using Piet.Programs;
using Piet.Runtime;
using System;
using System.IO;

namespace Benchmarks;

public static class Runner
{
    public static IReadOnlyList<object> Run(ExecutableContext ctx)
    {
        ctx.Reset();
        ctx.Program(State.New(ctx));
        return ctx.Output;
    }

    public static IReadOnlyList<object> Run(InterpreterContext ctx)
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

    public static ExecutableContext Ctx(Func<State, bool> program, params int[] ints) => new()
    {
        Program = program,
        Ints = [.. ints],
    };


    extension(Stream stream)
    {
        public InterpreterContext Ctx(params int[] ints) => new()
        {
            Program = stream.Program(),
            Ints = [.. ints],
        };
    }
}
