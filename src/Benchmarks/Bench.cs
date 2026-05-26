namespace Benchmarks;

internal static class Bench
{
    public static void Main()
        => BenchmarkDotNet.Running.BenchmarkRunner.Run<Executed>();
}
