using BenchmarkDotNet.Attributes;
using Compiled = Piet.Programs.Compiled;

namespace Benchmarks;

[MemoryDiagnoser]
public class Executed
{
    private readonly ExecutableContext dayOfWeek = Runner.Ctx(Compiled.DayOfWeek.Execute, 2017, 06, 11);
    private readonly ExecutableContext fizzBuzz = Runner.Ctx(Compiled.FizzBuzz.Execute, 30 * 15 * 83);
    private readonly ExecutableContext gnomeSort = Runner.Ctx(Compiled.GnomeSort.Execute, 4, 17, 69, 0, 42);
    private readonly ExecutableContext pi = Runner.Ctx(Compiled.Pi.Execute);
    private readonly ExecutableContext powerFunction = Runner.Ctx(Compiled.PowerFunction.Execute, 17, 3);
    
    [Benchmark]
    public IReadOnlyList<object> DayOfWeek()
        => Runner.Run(dayOfWeek);

    [Benchmark]
    public IReadOnlyList<object> FizzBuzz()
        => Runner.Run(fizzBuzz);


    [Benchmark]
    public IReadOnlyList<object> GnomeSort()
        => Runner.Run(gnomeSort);

    [Benchmark]
    public IReadOnlyList<object> Pi()
        => Runner.Run(pi);

    [Benchmark]
    public IReadOnlyList<object> PowerFunction()
        => Runner.Run(powerFunction);
}
