using PietDotNet.IO;

namespace Specs.Tooling;

public class TestIO : InOut
{
    private readonly StringBuilder sb = new();

    public Queue<char?> InChrs { get; } = new Queue<char?>();
    public Queue<long?> InInts { get; } = new Queue<long?>();
    public List<long> OutInts { get; } = [];


    public char? InChr() => InChrs.Dequeue();
    public long? InInt() => InInts.Dequeue();

    public void Out(long n)
    {
        Write(n);
        sb.Append(n);
        OutInts.Add(n);
    }

    public void Out(char c)
    {
        Write(c);
        sb.Append(c);
    }

    public override string ToString() => sb.ToString();

    /// <inheritdoc cref="Console.Write(string?)" />
    public static void Write(object? value)
    {
#if DEBUG
        Console.Write(value);
#endif
    }

    public static class Error
    {
        /// <inheritdoc cref="Console.WriteLine(string?)" />
        public static void WriteLine(string? value)
        {
#if DEBUG
            Console.Error.WriteLine(value);
#endif
        }
    }

}
