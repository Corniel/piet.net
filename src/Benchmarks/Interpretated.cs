using BenchmarkDotNet.Attributes;
using Piet.Programs;

namespace Benchmarks;

[MemoryDiagnoser]
public class Interpretated
{
    private readonly InterpreterContext dayOfWeek = Streams.DayOfWeek.Ctx(2017, 06, 11);
    private readonly InterpreterContext fizzBuzz = Streams.FizzBuzz.Ctx(30 * 15 * 83);
    private readonly InterpreterContext gnomeSort = Streams.GnomeSort.Ctx(4, 17, 69, 0, 42);
    private readonly InterpreterContext pi = Streams.Pi.Ctx();
    private readonly InterpreterContext powerFunction = Streams.PowerFunction.Ctx(17, 3);

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
