namespace PietDotNet.Tests.Tooling;

internal static class StackAssert
{
    public static void AreEqual(Stack actual, params long[] expected)
    {
        if (!Enumerable.SequenceEqual(actual, expected))
        {
            Assert.Fail($"Expected: {string.Join(", ", expected)}\r\nBut was:  {string.Join(", ", actual)}");
        }
    }
}
