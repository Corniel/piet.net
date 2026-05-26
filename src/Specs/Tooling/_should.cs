using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace AwesomeAssertions;

internal static class Shoulds
{
	[Pure]
	[OverloadResolutionPriority(int.MaxValue)]
	public static StackAssertions Should(this Stack stack) => new(stack);

    [Pure]
	[OverloadResolutionPriority(int.MaxValue)]
	public static RunAssertions Should(this RunResult result) => new(result);

    public static StateAssertions Should(this Piet.Runtime.State state) => new(new StateInfo
    {
        PT = state.PT,
        Stack = [.. state.Stack],
    });
}
