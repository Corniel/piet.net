namespace Specs.Tooling;

internal sealed class RunAssertions(RunResult subject)
{
    public RunResult Subject { get; } = subject;

	public void HaveOutput(string output)
        => Subject.IO.ToString().Should().Be(output);

    public void HaveOutput(params long[] output)
	    => Subject.IO.OutInts.Should().BeEquivalentTo(output);
}
