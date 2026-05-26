using Piet.Interpreting.Logging;
using Piet.Runtime.IO;
using Piet.Syntax;

namespace Benchmarks;

[Mutable]
public sealed record RunnerContext : InOut
{
    public RunnerContext Reset()
    {
        chars = 0;
        ints = 0;
        Output.Clear();
        return this;
    }
    public required Program Program { get; init; }

    public Logger Logger { get; init; } = new NullLogger();

    public int MaxRuns { get; init; } = int.MaxValue;

    public ImmutableArray<char> Chars { get; init; } = [];

    public ImmutableArray<long> Ints { get; init; } = [];

    public List<object> Output { get; } = [];

    public char? InChr() => chars < Chars.Length ? Chars[chars++] : null;

    public long? InInt() => ints < Ints.Length ? Ints[ints++] : null;

    public void Out(long n) => Output.Add(n);

    public void Out(char c) => Output.Add(c);

    private int chars;
    private int ints;

    private sealed class NullLogger : Logger
    {
        public LogLevel MinLevel => LogLevel.Fatal;

        public void Log(LogLevel level, string message) { /* Void. */ }
    }
}
