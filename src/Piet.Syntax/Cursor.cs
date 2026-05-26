namespace Piet.Syntax;

/// <summary>Represents the cursor with its codel and <see cref="CC_DP"/>.</summary>
public readonly record struct Cursor(CC_DP PT, Codel Codel) : IEquatable<Cursor>
{
    public static readonly Cursor Initial;

    public Cursor Next() => new(PT, Codel.Next(PT));

    /// <summary>Moves the pointer based on the <see cref="PP"/>.</summary>
    public Cursor Move(Codel codel) => new(PT, codel);

    /// <summary>Rotates the DP clockwise that many steps (anticlockwise if negative).</summary>
    public Cursor Rotate(long rotate = 1) => new(PT.Rotate(rotate), Codel);

    /// <summary>Toggles the CC that many times (the absolute value of that many times if negative).</summary>
    public Cursor Switch(long @switch = 1) => new(PT.Switch(@switch), Codel);

    /// <inheritdoc />
    public override string ToString() => $"{Codel}, CC-DP = {PT}";
}
