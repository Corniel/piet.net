namespace System
{
    public static class ModExtensions
    {
        public static int Mod(this int n, int mod)
        {
            var result = n % mod;
            return result < 0 ? result + mod : result;
        }
        public static long Mod(this long n, long mod)
        {
            var result = n % mod;
            return result < 0 ? result + mod : result;
        }
    }
}
