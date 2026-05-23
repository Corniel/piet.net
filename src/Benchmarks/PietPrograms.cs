using BenchmarkDotNet.Attributes;

namespace Benchmarks;

[MemoryDiagnoser]
public class PietPrograms
{
    [Benchmark]
    public IReadOnlyList<object> DayOfWeek()
        => Runner.Run(Programs.DayOfWeek, 2017, 06, 11);

    [Benchmark]
    public IReadOnlyList<object> FizzBuzz()
        => Runner.Run(Programs.FizzBuzz, 30 * 15 * 83);

    [Benchmark]
    public IReadOnlyList<object> GnomeSort()
        => Runner.Run(Programs.GnomeSort, 4, 17, 69, 0, 42);
}
