using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace PietDotNet
{
    /// <summary>Represents a Piet program.</summary>
    /// <remarks>
    /// Piet is a programming language in which programs look like abstract
    /// paintings. The language is named after Piet Mondrian, who pioneered the
    /// field of geometric abstract art.
    /// </remarks>
    public class Program
    {
        private readonly Codel[,] _canvas;
        private readonly ColourBlock[,] _blocks;

        /// <summary>Creates a new instance of a Piet <see cref="Program"/>.</summary>
        public Program(Codel[,] canvas)
        {
            _canvas = canvas;
            Width = canvas.GetLength(0);
            Height = canvas.GetLength(1);
            _blocks = new ColourBlock[Width, Height];
        }

        /// <summary>Gets the width of the program.</summary>
        public int Width { get; }

        /// <summary>Gets the height of the program.</summary>
        public int Height { get; }

        /// <summary>Gets the codel of the pointer.</summary>
        public Codel this[Point pointer] => OnCanvas(pointer) ? _canvas[pointer.X, pointer.Y] : Codel.Black;

        /// <summary>Gets the value of the colour block.</summary>
        /// <param name="pointer">
        /// A point of the program that is member of the colour block.
        /// </param>
        public ColourBlock Block(Point pointer)
        {
            if (this[pointer].IsBlack)
            {
                return ColourBlock.Border;
            }
            var val = _blocks[pointer.X, pointer.Y];
            return val is null
                ? DetermineColourBlock(pointer)
                : val;
        }

        /// <summary>Returns true if the point is on canvas, otherwise false.</summary>
        public bool OnCanvas(Point pointer)
        {
            return pointer.X >= 0
                && pointer.Y >= 0
                && pointer.X < Width
                && pointer.Y < Height;
        }

        /// <summary>Determines the value of the colour block.</summary>
        /// <param name="pointer">
        /// A point of the program that is member of the colour block.
        /// </param>
        private ColourBlock DetermineColourBlock(Point pointer)
        {
            var codel = this[pointer];
            var counter = 0;
            var visited = new HashSet<Point>();
            var todo = new Queue<Point>();

            todo.Enqueue(pointer);

            while (todo.TryDequeue(out var p))
            {
                // Black, or white (or not on canvas).
                if (this[p].IsBlack) continue;
                // Already visited.
                if (visited.Contains(p)) continue;
                // Already with a value.
                if (_blocks[p.X, p.Y] != null) continue;
                // We don't want to do things twice.
                if (!visited.Add(p)) continue;

                var testCodel = this[p];
                if (codel == testCodel)
                {
                    counter++;
                    todo.Enqueue(p.Next(DirectionPointer.top));
                    todo.Enqueue(p.Next(DirectionPointer.right));
                    todo.Enqueue(p.Next(DirectionPointer.down));
                    todo.Enqueue(p.Next(DirectionPointer.left));
                }
            }

            var block = new ColourBlock(codel, visited.Where(p => this[p] == codel));

            foreach (var p in block)
            {
                _blocks[p.X, p.Y] = block;
            }
            return block;
        }

        /// <summary>Creates a <see cref="Program"/> from a <see cref="FileInfo"/>.</summary>
        public static Program From(FileInfo file, int codelSize = 1)
        {
            Guard.NotNull(file, nameof(file));

            if (!file.Exists)
            {
                throw new FileNotFoundException($"Program '{file}' does not exist.", file.FullName);
            }
            return From(file.OpenRead(), codelSize);
        }

        /// <summary>Creates a <see cref="Program"/> from a <see cref="Stream"/>.</summary>
        public static Program From(Stream stream, int codelSize = 1)
        {
            Guard.NotNull(stream, nameof(stream));

            var image = Image.FromStream(stream);
            return From(new Bitmap(image), codelSize);
        }

        /// <summary>Creates a <see cref="Program"/> from a <see cref="Bitmap"/>.</summary>
        public static Program From(Bitmap bitmap, int codelSize = 1)
        {
            Guard.NotNull(bitmap, nameof(bitmap));
            Guard.Positive(codelSize, nameof(codelSize));

            if (bitmap.Width % codelSize != 0 || bitmap.Height % codelSize != 0)
            {
                throw new BadImageFormatException($"The dimensions ({bitmap.Width} x {bitmap.Height}) do not go along with a codel size of {codelSize}.");
            }

            var width = bitmap.Width / codelSize;
            var height = bitmap.Height / codelSize;
            var canvas = new Codel[width, height];
            // Get the codels
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    var colour = bitmap.GetPixel(x * codelSize, y * codelSize);
                    var type = Codel.From(colour);

                    if (type is null)
                    {
                        throw new BadImageFormatException($"The colour '#{colour.R.ToString("X2")}{colour.G.ToString("X2")}{colour.B.ToString("X2")}' of codel ({x}, {y}) is not allowed.");
                    }
                    canvas[x, y] = type;
                }
            }

            var program = new Program(canvas);

            return program;
        }
    }
}
