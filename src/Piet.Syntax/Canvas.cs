namespace Piet.Syntax;

public abstract class Canvas<T>(T[][] grid)
{
    private readonly T[][] Grid = grid;

    /// <summary>Gets the width of the canvas.</summary>
    public int Width { get; } = grid.Length;

    /// <summary>Gets the height of the canvas.</summary>
    public int Height { get; } = grid[0].Length;

    protected abstract T NaN { get; }

    /// <summary>Gets the colour of the codel.</summary>
    public T this[Codel codel]
    {
        get => OnCanvas(codel) ? Grid[codel.X][codel.Y] : NaN;
        set => Grid[codel.X][codel.Y] = value;
    }

    /// <summary>Returns true if the point is on canvas, otherwise false.</summary>
    public bool OnCanvas(Codel codel)
        => codel.X >= 0
        && codel.Y >= 0
        && codel.X < Width
        && codel.Y < Height;
}
