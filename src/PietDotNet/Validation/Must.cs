namespace PietDotNet.Validation
{
    internal static class Must
    {
        /// <summary>Guards that the stack has at least one item.</summary>
        public static Stack HasAny(this Stack stack)
        {
            return stack.Count >= 1
                ? stack
                : throw new InsufficientStackSize();
        }

        /// <summary>Guards that the stack has at least two items.</summary>
        public static Stack HasMultiple(this Stack stack)
        {
            return stack.Count >= 2
                ? stack
                : throw new InsufficientStackSize();
        }

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
