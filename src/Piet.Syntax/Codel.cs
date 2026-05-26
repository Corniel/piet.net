namespace Piet.Syntax;

/// <summary>Represents a codel (position).</summary>
/// <remarks>
///  Individual pixels of colour are significant in the language, so it is
///  common for programs to be enlarged for viewing so that the details are
///  easily visible. In such enlarged programs, the term "codel" is used to
///  mean a block of colour equivalent to a single pixel of code, to avoid
///  confusion with the actual pixels of the enlarged graphic, of which
///  many may make up one codel. 
/// </remarks>
public readonly record struct Codel(int X, int Y) : IEquatable<Codel>
{
    /// <summary>The (0, 0) entry point codel.</summary>
    public static readonly Codel EntryPoint;

    /// <summary>Moves to the next codel based on the <see cref="DP"/>.</summary>
    public Codel Next(CC_DP pt) => pt.DP switch
    {
        0 => new(X + 1, Y + 0),
        1 => new(X + 0, Y + 1),
        2 => new(X - 1, Y + 0),
        3 => new(X + 0, Y - 1),
        _ => throw new ArgumentOutOfRangeException(nameof(pt)),
    };

    /// <inheritdoc />
    public override string ToString() => $"({X}, {Y})";
}
