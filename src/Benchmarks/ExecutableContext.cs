using Piet.Runtime;
using System;

namespace Benchmarks;

[Mutable]
public sealed record ExecutableContext : Context<ExecutableContext>
{
    public required Action<State> Program { get; init; }
}
