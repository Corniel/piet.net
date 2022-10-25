namespace PietDotNet.Tests.Tooling;

internal static class RunAssert
{
    public static void HasOutput(RunResult result, string expected)
    {
        Assert.AreEqual(expected, result.IO.ToString());
    }

    public static void HasNumericOutput(RunResult result, params long[] expected)
    {
        Assert.AreEqual(expected, result.IO.OutInts);
    }
}
