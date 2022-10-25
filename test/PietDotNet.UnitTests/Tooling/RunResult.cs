namespace PietDotNet.Tests.Tooling;

internal class RunResult
{
    public TestIO IO { get; }
    public UnitTestLogger Logger { get; }

    public RunResult(TestIO io, UnitTestLogger logger)
    {
        IO = io;
        Logger = logger;
    }
}
