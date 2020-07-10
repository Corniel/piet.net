namespace PietDotNet.Validation
{
    internal static class Must
    {
        public static long HasInput(this long? value)
        {
            return value ?? throw new InvalidInput();
        }

        public static long HasInput(this char? value)
        {
            return value ?? throw new InvalidInput();
        }
    }
}
