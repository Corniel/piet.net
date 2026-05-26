namespace Piet.Runtime.IO;

/// <summary>
///  <see cref="InOut"/> via the <see cref="Console"/>.
/// </summary>
public sealed class ConsoleInOut : InOut
{
    internal ConsoleInOut() { }

    /// <inheritdoc />
    public char? InChr()
    {
        var input = Console.Read();
        return input > -1
            ? (char)input
            : null;
    }

    /// <inheritdoc />
    public long? InInt()
    {
        var input = Console.ReadLine();
        return long.TryParse(input, out var @in)
            ? @in
            : null;
    }

    /// <inheritdoc />
    public void Out(long n) => Console.Write(n);

    /// <inheritdoc />
    public void Out(char c) => Console.Write(c);
}
