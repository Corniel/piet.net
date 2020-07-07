using System;

namespace PietDotNet
{
    public enum DirectionPointer
    {
        right = 0,
        down = 1,
        left = 2,
        top = 3,
    }

    public static class DirectionPointerExtensions
    {
        public static DirectionPointer Rotate(this DirectionPointer dp, long steps)
        {
            return (DirectionPointer)((long)dp + steps).Modulo(4);
        }
    }
}
