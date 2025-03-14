namespace PietDotNet;

/// <summary>Represents a codel (position).</summary>
/// <remarks>
///  Individual pixels of colour are significant in the language, so it is
///  common for programs to be enlarged for viewing so that the details are
///  easily visible. In such enlarged programs, the term "codel" is used to
///  mean a block of colour equivalent to a single pixel of code, to avoid
///  confusion with the actual pixels of the enlarged graphic, of which
///  many may make up one codel. 
/// </remarks>
public readonly struct Codel : IEquatable<Codel>
{
    public Codel(int x, int y)
    {
        X = x;
        Y = y;
    }

    /// <summary>Gets the x-coordinate of the codel.</summary>
    public int X { get; }

    /// <summary>Gets the y-coordinate of the codel.</summary>
    public int Y { get; }

    /// <summary>Moves to the next codel based on the <see cref="DirectionPointer"/>.</summary>
    public Codel Next(DirectionPointer dp) => dp switch
    {
        DirectionPointer.right => /*.*/ new(X + 1, Y + 0),
        DirectionPointer.left => /*..*/ new(X - 1, Y + 0),
        DirectionPointer.top => /*...*/ new(X + 0, Y - 1),
        DirectionPointer.down => /*..*/ new(X + 0, Y + 1),
        _ => throw new ArgumentOutOfRangeException(nameof(dp)),
    };

    /// <inheritdoc />
    public override string ToString() => $"({X}, {Y})";

    /// <inheritdoc />
    public override bool Equals(object obj) => obj is Codel other && Equals(other);

    /// <inheritdoc />
    public bool Equals(Codel other) => X == other.X && Y == other.Y;

    /// <inheritdoc />
    public override int GetHashCode() => X ^ (Y << 15);
}
