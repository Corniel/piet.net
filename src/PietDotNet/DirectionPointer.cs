namespace PietDotNet;

public enum DirectionPointer
{
    right = 0,
    down = 1,
    left = 2,
    top = 3,
}

public static class DirectionPointerExtensions
{
    extension(DirectionPointer dp)
    {
        public DirectionPointer Rotate(long steps) => (DirectionPointer)((long)dp + steps).Modulo(4);
    }
}
