using PietDotNet;

namespace System.Drawing
{
    /// <summary>Extensions on <see cref="Point"/>.</summary>
    public static class PointExtensions
    {
        /// <summary>Moves to the next point based on the <see cref="DirectionPointer"/>.</summary>
        public static Point Next(this Point point, DirectionPointer dp)
        {
            switch (dp)
            {
                case DirectionPointer.right: /**/ return new Point(point.X + 1, point.Y + 0);
                case DirectionPointer.left: /* */ return new Point(point.X - 1, point.Y + 0);
                case DirectionPointer.top: /*  */ return new Point(point.X + 0, point.Y - 1);
                case DirectionPointer.down: /* */ return new Point(point.X + 0, point.Y + 1);
                default: throw new InvalidOperationException();
            }
        }

        /// <summary>Moves left or right based on the <see cref="CodelChooser"/> and the <see cref="DirectionPointer"/>.</summary>
        public static Point Next(this Point point, DirectionPointer dp, CodelChooser cc)
        {
            Guard.DefinedEnum(cc, nameof(cc));
            var left = cc == CodelChooser.left;

            switch (dp)
            {
                case DirectionPointer.right: /**/ return new Point(point.X, point.Y + (left ? -1 : +1));
                case DirectionPointer.left: /* */ return new Point(point.X, point.Y + (left ? +1 : -1));
                case DirectionPointer.top: /*  */ return new Point(point.X + (left ? -1 : +1), point.Y);
                case DirectionPointer.down: /* */ return new Point(point.X + (left ? +1 : -1), point.Y);
                default: throw new InvalidOperationException();
            }
        }

        public static string Debug(this Point point) => $"({point.X},{(point.X < 10 ? " " : "")} {point.Y,2})";
    }
}
