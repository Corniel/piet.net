using BenchmarkDotNet.Attributes;
using Piet.Programs;

namespace Benchmarks;

[MemoryDiagnoser]
public class PietPrograms
{
    private readonly RunnerContext dayOfWeek = Streams.DayOfWeek.Ctx(2017, 06, 11);
    private readonly RunnerContext fizzBuzz = Streams.FizzBuzz.Ctx(30 * 15 * 83);
    private readonly RunnerContext gnomeSort = Streams.GnomeSort.Ctx(4, 17, 69, 0, 42);
    private readonly RunnerContext pi = Streams.Pi.Ctx();
    private readonly RunnerContext powerFunction = Streams.PowerFunction.Ctx();

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
