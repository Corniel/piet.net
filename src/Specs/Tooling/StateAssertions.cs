namespace AwesomeAssertions;

internal sealed class StateAssertions(StateInfo subject)
{
    public StateInfo Subject { get; } = subject;

    public void Be(StateInfo expectation)
        => Subject.Should().BeEquivalentTo(expectation);
}
