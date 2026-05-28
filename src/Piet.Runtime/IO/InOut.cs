namespace Piet.Runtime.IO;

public interface InOut
{
    /// <inheritdoc cref="ConsoleInOut" />
    static readonly ConsoleInOut Console = new();

    /// <summary>Reads a <see cref="long"/>.</summary>
    long? InInt();

    /// <summary>Reads a <see cref="char"/>.</summary>
    char? InChr();

    /// <summary>Writes a <see cref="long"/>.</summary>
    void Out(long n);

    /// <summary>Writes a <see cref="char"/>.</summary>
    void Out(char c);
}
