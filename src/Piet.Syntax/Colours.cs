using System.Drawing;
using System.IO;

namespace Piet.Syntax;

public sealed class Colours(Colour[][] grid) : Canvas<Colour>(grid)
{
    protected override Colour NaN => Colour.Black;

    /// <summary>Creates a <see cref="Program"/> from a <see cref="FileInfo"/>.</summary>
    public static Colours Load(FileInfo file, int codelSize = 1)
        => file.Exists
        ? Load(file.OpenRead(), codelSize)
        : throw new FileNotFoundException($"Program '{file}' does not exist.", file.FullName);

    /// <summary>Creates a <see cref="Program"/> from a <see cref="Stream"/>.</summary>
    public static Colours Load(Stream stream, int codelSize = 1)
    {
        var image = Image.FromStream(stream);
        return Load(new Bitmap(image), codelSize);
    }


    public static Colours Load(Bitmap bitmap, int codelSize = 1)
    {
        if (bitmap.Width % codelSize != 0 || bitmap.Height % codelSize != 0)
        {
            throw new BadImageFormatException($"The dimensions ({bitmap.Width} x {bitmap.Height}) do not go along with a codel size of {codelSize}.");
        }

        var width = bitmap.Width / codelSize;
        var height = bitmap.Height / codelSize;
        var canvas = Jagged.Array<Colour>(width, height);
        // Get the codels
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                var color = bitmap.GetPixel(x * codelSize, y * codelSize);
                canvas[x][y] = Colour.From(color)
                    ?? throw new BadImageFormatException($"The color '#{color.R:X2}{color.G:X2)}{color.B:X2)}' of codel ({x}, {y}) is not allowed.");
            }
        }

        return new(canvas);
    }
}
