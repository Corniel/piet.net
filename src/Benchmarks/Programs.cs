#pragma warning disable CA1822 // Mark members as static

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Piet.Programs;
using Compiled = Piet.Programs.Compiled;

namespace Benchmarks;

[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
[MemoryDiagnoser]
public class Programs
{
    private static class Exe
    {
        public static readonly ExecutableContext DayOfWeek = Runner.Ctx(Compiled.DayOfWeek.Execute, 2017, 06, 11);
        public static readonly ExecutableContext FizzBuzz = Runner.Ctx(Compiled.FizzBuzz.Execute, 30 * 15 * 83);
        public static readonly ExecutableContext GnomeSort = Runner.Ctx(Compiled.GnomeSort.Execute, 4, 17, 69, 0, 42);
        public static readonly ExecutableContext Pi = Runner.Ctx(Compiled.Pi.Execute);
        public static readonly ExecutableContext PowerFunction = Runner.Ctx(Compiled.PowerFunction.Execute, 17, 3);
    }
    private static class Eval
    {
        public static readonly InterpreterContext DayOfWeek = Streams.DayOfWeek.Ctx(2017, 06, 11);
        public static readonly InterpreterContext FizzBuzz = Streams.FizzBuzz.Ctx(30 * 15 * 83);
        public static readonly InterpreterContext GnomeSort = Streams.GnomeSort.Ctx(4, 17, 69, 0, 42);
        public static readonly InterpreterContext Pi = Streams.Pi.Ctx();
        public static readonly InterpreterContext PowerFunction = Streams.PowerFunction.Ctx(17, 3);
    }

    [Benchmark(Baseline = true), BenchmarkCategory(nameof(Exe.DayOfWeek))]
    public IReadOnlyList<object> DayOfWeek_exe() => Runner.Run(Exe.DayOfWeek);

    [Benchmark, BenchmarkCategory(nameof(Eval.DayOfWeek))]
    public IReadOnlyList<object> DayOfWeek_eval() => Runner.Run(Eval.DayOfWeek);


    [Benchmark(Baseline = true), BenchmarkCategory(nameof(Exe.FizzBuzz))]
    public IReadOnlyList<object> FizzBuzz_exe() => Runner.Run(Exe.FizzBuzz);

    [Benchmark, BenchmarkCategory(nameof(Eval.FizzBuzz))]
    public IReadOnlyList<object> FizzBuzz_eval() => Runner.Run(Eval.FizzBuzz);


    [Benchmark(Baseline = true), BenchmarkCategory(nameof(Exe.GnomeSort))]
    public IReadOnlyList<object> GnomeSort_exe() => Runner.Run(Exe.GnomeSort);

    [Benchmark, BenchmarkCategory(nameof(Eval.GnomeSort))]
    public IReadOnlyList<object> GnomeSort_eval() => Runner.Run(Eval.GnomeSort);


    [Benchmark(Baseline = true), BenchmarkCategory(nameof(Exe.Pi))]
    public IReadOnlyList<object> Pi_exe() => Runner.Run(Exe.Pi);

    [Benchmark, BenchmarkCategory(nameof(Eval.Pi))]
    public IReadOnlyList<object> Pi_eval() => Runner.Run(Eval.Pi);


    [Benchmark(Baseline = true), BenchmarkCategory(nameof(Exe.PowerFunction))]
    public IReadOnlyList<object> PowerFunction_exe() => Runner.Run(Exe.PowerFunction);

    [Benchmark, BenchmarkCategory(nameof(Eval.PowerFunction))]
    public IReadOnlyList<object> PowerFunction_eval() => Runner.Run(Eval.PowerFunction);
}
