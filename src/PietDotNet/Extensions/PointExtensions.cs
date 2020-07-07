using PietDotNet;

namespace System.Drawing
{
    /// <summary>Extensions on <see cref="Point"/>.</summary>
    public static class PointExtensions
    {
        /// <summary>Moves to the next point based on the <see cref="DirectionPointer"/>.</summary>
        public static Point Next(this Point point, DirectionPointer dp)
        {
            return dp switch
            {
                DirectionPointer.right => /**/ new Point(point.X + 1, point.Y + 0),
                DirectionPointer.left => /* */ new Point(point.X - 1, point.Y + 0),
                DirectionPointer.top => /*  */ new Point(point.X + 0, point.Y - 1),
                DirectionPointer.down => /* */ new Point(point.X + 0, point.Y + 1),
                _ => throw new InvalidOperationException(),
            };
        }

        internal static string Debug(this Point point) => $"({point.X},{(point.X < 10 ? " " : "")} {point.Y,2})";
    }
}
