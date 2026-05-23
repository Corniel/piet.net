using System.Linq;

namespace Benchmarks;

public static class Runner
{
    public static IReadOnlyList<object> Run(PietDotNet.Program program, params ImmutableArray<long> ints)
    {
        var context = new RunnerContext() { Ints = ints };
        return Run(program, context);

    }
    public static IReadOnlyList<object> Run(PietDotNet.Program program, RunnerContext? context)
    {
        context ??= new();
        context.Output.Clear();
        program.Run(context, context.Logger, context.MaxRuns);
        return context.Output;
    }
}
