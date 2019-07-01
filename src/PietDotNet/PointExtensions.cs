using PietDotNet;

namespace System.Drawing
{
    public static class PointExtensions
    {
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
    }
}
