namespace Piet.Runtime.IO;

public interface InOut
{
    /// <inheritdoc cref="ConsoleInOut" />
    static readonly ConsoleInOut Console = new();

    /// <summary>Reads an <see cref="long"/>.</summary>
    long? InInt();

    /// <summary>Reads an <see cref="long"/>.</summary>
    char? InChr();

    void Out(long n);
    void Out(char c);
}
