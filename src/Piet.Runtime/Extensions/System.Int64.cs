namespace System;

internal static class Int64Extensions
{
    extension(long n)
    {
        public long Modulo(long modulo)
        {
            var result = n % modulo;
            return result >= 0 ? result : result + modulo;
        }
    }
}
