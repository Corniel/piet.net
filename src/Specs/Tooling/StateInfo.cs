using Piet.Runtime;
using System.Collections.Immutable;

namespace Specs.Tooling;

internal sealed record StateInfo
{
    public CC_DP PT { get; init; }

    public ImmutableArray<long> Stack { get; init; } = [];

    public static State New(long[]? stack = null)
    {
        var state = State.New();
        foreach (var item in stack ?? [])
            state.Stack = state.Stack.Push(item);

        return state;
    }
}
