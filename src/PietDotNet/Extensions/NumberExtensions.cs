namespace System;

internal static class NumberExtensions
{
    public static bool IsEven(this int number) => (number & 1) == 0;

    public static int Modulo(this int n, int modulo) => (int)Modulo((long)n, modulo);
    
    public static long Modulo(this long n, long modulo)
    {
        var result = n % modulo;
        return result >= 0 ? result : result + modulo;
    }
}
