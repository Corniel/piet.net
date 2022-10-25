namespace PietDotNet;

/// <summary>Represents a Piet program.</summary>
/// <remarks>
/// Piet is a programming language in which programs look like abstract
/// paintings. The language is named after Piet Mondrian, who pioneered the
/// field of geometric abstract art.
/// </remarks>
public class Program : IEnumerable<Colour>
{
    private readonly Colour[][] _codels;
    private readonly ColourBlock[][] _blocks;

    /// <summary>Creates a new instance of a Piet <see cref="Program"/>.</summary>
    internal Program(Colour[][] codels)
    {
        _codels = codels;
        Width = codels.Length;
        Height = codels[0].Length;
        _blocks = Jagged.Array<ColourBlock>(Width, Height);
    }

    /// <summary>Gets the width of the program.</summary>
    public int Width { get; }

    /// <summary>Gets the height of the program.</summary>
    public int Height { get; }

    /// <summary>Gets the codel of the pointer.</summary>
    public Colour this[Codel position] => OnCanvas(position) ? _codels[position.X][position.Y] : Colour.Black;

    /// <summary>Gets the value of the colour block.</summary>
    public ColourBlock SelectBlock(State state) => SelectBlock(state.Pointer.Position);

    /// <summary>Gets the value of the colour block.</summary>
    /// <param name="position">
    /// A position of the program that is member of the colour block.
    /// </param>
    public ColourBlock SelectBlock(Codel position)
    {

        if (this[position].IsBlack)
        {
            return ColourBlock.Border;
        }

        var val = _blocks[position.X][position.Y];
        return val is null
            ? DetermineColourBlock(position)
            : val;
    }

    /// <summary>Returns true if the point is on canvas, otherwise false.</summary>
    public bool OnCanvas(Codel codel)
    {
        return codel.X >= 0
            && codel.Y >= 0
            && codel.X < Width
            && codel.Y < Height;
    }

    /// <summary>Determines the value of the colour block.</summary>
    /// <param name="pointer">
    /// A point of the program that is member of the colour block.
    /// </param>
    private ColourBlock DetermineColourBlock(Codel pointer)
    {
        var colour = this[pointer];
        var counter = 0;
        var visited = new HashSet<Codel>();
        var todo = new Queue<Codel>();

        todo.Enqueue(pointer);

        while (todo.TryDequeue(out var p))
        {
            if (this[p].IsBlack ||
                visited.Contains(p) ||
                _blocks[p.X][p.Y] != null) continue;

            // We don't want to do things twice.
            if (!visited.Add(p)) continue;

            var testColour = this[p];
            if (colour == testColour)
            {
                counter++;
                todo.Enqueue(p.Next(DirectionPointer.top));
                todo.Enqueue(p.Next(DirectionPointer.right));
                todo.Enqueue(p.Next(DirectionPointer.down));
                todo.Enqueue(p.Next(DirectionPointer.left));
            }
        }

        var codels = visited.Where(p => this[p] == colour);

        var block = new ColourBlock(colour, codels);

        foreach (var codel in codels)
        {
            _blocks[codel.X][codel.Y] = block;
        }
        return block;
    }

    public IEnumerator<Colour> GetEnumerator() => Enumerate().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    private IEnumerable<Colour> Enumerate()
    {
        for (var x = 0; x < Width; x++)
        {
            for (var y = 0; y < Height; y++)
            {
                yield return _codels[x][y];
            }
        }
    }
}
