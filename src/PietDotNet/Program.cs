using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace PietDotNet
{
    public class Program
    {
        private readonly Codel[,] _canvas;
        private readonly int[,] _values;

        public Program(Codel[,] canvas, int[,] values)
        {
            _canvas = canvas;
            _values = values;
            Width = canvas.GetLength(0);
            Height = canvas.GetLength(1);
        }

        public int Width { get; }
        public int Height { get; }

        public Codel this[Point point] => OnCanvas(point) ? _canvas[point.X, point.Y] : Codel.Black;

        public int Value(Point point)
        {
            var val = _values[point.X, point.Y];
            if (val == 0)
            {
                DetermineValueOfColourBlock(point);
                val = _values[point.X, point.Y];
            }
            return val;
        }

        public bool OnCanvas(Point point)
        {
            return point.X >= 0
                && point.Y >= 0
                && point.X < Width
                && point.Y < Height;
        }

        public void DetermineValueOfColourBlock(Point point)
        {
            var counter = 0;
            var visited = new HashSet<Point>();
            var todo = new Queue<Point>();
            var codel = this[point];

            if (!codel.IsBlack && !codel.IsWhite)
            {
                todo.Enqueue(point);

                while (todo.TryDequeue(out var p))
                {
                    if (!OnCanvas(p)) continue;
                    if (visited.Contains(p)) continue;

                    var currentCodel = this[p];
                    visited.Add(p);
                    if (codel == currentCodel)
                    {
                        counter++;
                        todo.Enqueue(new Point(p.X, p.Y + 1));
                        todo.Enqueue(new Point(p.X, p.Y - 1));
                        todo.Enqueue(new Point(p.X + 1, p.Y));
                        todo.Enqueue(new Point(p.X - 1, p.Y));
                    }
                }

                foreach (var p in visited)
                {
                    if (this[p] == codel)
                    {
                        _values[p.X, p.Y] = counter;
                    }
                }
            }
        }

        public static Program From(FileInfo file, int codelSize =1)
        {
            Guard.NotNull(file, nameof(file));

            if(!file.Exists)
            {
                throw new FileNotFoundException($"Program '{file}' does not exist.", file.FullName);
            }
            return From(file.OpenRead(), codelSize);
        }
        public static Program From(Stream stream, int codelSize = 1)
        {
            Guard.NotNull(stream, nameof(stream));

            var image = Image.FromStream(stream);
            return From(new Bitmap(image), codelSize);
        }
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
            var values = new int[width, height];

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

                    if (type.NotBlackOrWhite)
                    {
                        values[x, y] = 0;
                    }
                }
            }

            var program = new Program(canvas, values);

            return program;
        }
    }
}
