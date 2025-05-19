using Stack = PietDotNet.Stack;

namespace Specs.Tooling;

internal sealed class StackAssertions(Stack subject)
{
	public Stack Subject { get; } = subject;

	public void Be(params long[] stack)
		=> AssertionChain.GetOrCreate()
		   .ForCondition(Enumerable.SequenceEqual(Subject, stack))
		   .FailWith($"Expected: {string.Join(", ", stack)}\r\nBut was:  {string.Join(", ", Subject)}");
}
