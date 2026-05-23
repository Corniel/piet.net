namespace Benchmarks;

internal static class Program
{
    public static void Main()
        => BenchmarkDotNet.Running.BenchmarkRunner.Run<PietPrograms>();
}
