using System.Collections.Immutable;

namespace Specs.Tooling;

internal sealed record StateInfo
{
    public Piet.Runtime.CC_DP PT { get; init; }

    public ImmutableArray<long> Stack { get; init; } = [];

    public static Piet.Runtime.State New(long[]? stack = null)
    {
        var state = Piet.Runtime.State.New();
        foreach (var item in stack ?? [])
            state.Stack = state.Stack.Push(item);

        return state;
    }
}
