using NUnit.Framework;

namespace PietDotNet.Tests.Tooling
{
    internal static class RunAssert
    {
        public static void HasStringOutput(RunResult result, string expected)
        {
            Assert.AreEqual(expected, result.IO.OutString);
        }

        public static void HasNumericOutput(RunResult result, params long[] expected)
        {
            Assert.AreEqual(expected, result.IO.OutInts);
        }
    }
}
