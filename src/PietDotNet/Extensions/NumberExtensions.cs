using System.Reflection;

namespace System;

internal static class NumberExtensions
{
    extension(long n)
    {
        public bool IsEven => (n & 1) is 0;

        public long Modulo(long modulo)
        {
            var result = n % modulo;
            return result >= 0 ? result : result + modulo;
        }
    }
    extension(int n)
    {
        public bool IsEven => (n & 1) is 0;

        public int Modulo(int modulo)
        {
            var result = n % modulo;
            return result >= 0 ? result : result + modulo;
        }
    }
}
