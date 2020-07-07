using NUnit.Framework;

namespace PietDotNet.Tests.Tooling
{
    internal static class StackAssert
    {
        public static void AreEqual(Stack actual, params long[] expected)
        {
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
