using Piet.Runtime;
using System;

namespace Benchmarks;

[Mutable]
public sealed record ExecutableContext : Context<ExecutableContext>
{
    public required Func<State, bool> Program { get; init; }
}
