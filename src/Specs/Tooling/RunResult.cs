namespace Specs.Tooling;

internal sealed class RunResult(TestIO io, UnitTestLogger logger)
{
    public TestIO IO { get; } = io;
    public UnitTestLogger Logger { get; } = logger;
}
