using System.Drawing;
using System.IO;

namespace Piet.Syntax;

public sealed class Program : Canvas<Block>
{
    private Program(Block[][] grid) : base(grid) { }

    protected override Block NaN => Block.Black;

    public static Program New(Colours colours)
    {
        var blocks = new Program(Jagged.Array<Block>(colours.Width, colours.Height));
        var unique = new HashSet<Block>();

        for (var x = 0; x < colours.Width; x++)
            for (var y = 0; y < colours.Height; y++)
                unique.Add(Find(new(x, y), blocks, colours));

        foreach (var block in unique.Where(b => !b.IsBlack && !b.IsWhite))
            block.Init(blocks);

        return blocks;
    }

    /// <summary>Determines the value of the colour block.</summary>
    /// <param name="codel">
    /// A point of the program that is member of the colour block.
    /// </param>
    private static Block Find(Codel codel, Program blocks, Colours colours)
    {
        // We're done.
        if (blocks[codel] is { } existing) return existing;

        var colour = colours[codel];
        var visited = new HashSet<Codel>();
        var todo = new Queue<Codel>();

        todo.Enqueue(codel);

        while (todo.TryDequeue(out var test))
        {
            if (colour == colours[test] && Do(test))
            {
                todo.Enqueue(test.Next(CC_DP.LT));
                todo.Enqueue(test.Next(CC_DP.LR));
                todo.Enqueue(test.Next(CC_DP.LD));
                todo.Enqueue(test.Next(CC_DP.LL));
            }
        }

        var codels = visited.Where(p => colours[p] == colour);
        var block = Block.New(colour, codels);

        foreach (var c in codels)
            blocks[c] = block;

        return block;

        bool Do(Codel codel)
            => !visited.Contains(codel)
            && blocks[codel] is null
            && visited.Add(codel);
    }

    /// <summary>Creates a <see cref="Program"/> from a <see cref="FileInfo"/>.</summary>
    public static Program Load(FileInfo file, int codelSize = 1)
        => Guard.NotNull(file).Exists
        ? Load(file.OpenRead(), codelSize)
        : throw new FileNotFoundException($"Program '{file}' does not exist.", file.FullName);

    /// <summary>Creates a <see cref="Program"/> from a <see cref="Stream"/>.</summary>
    public static Program Load(Stream stream, int codelSize = 1)
    {
        Guard.NotNull(stream);

        var image = Image.FromStream(stream);
        return Load(new Bitmap(image), codelSize);
    }

    public static Program Load(Bitmap bitmap, int codelSize = 1)
        => New(Colours.Load(bitmap, codelSize));
}
