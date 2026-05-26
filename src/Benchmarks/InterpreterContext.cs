using Piet.Syntax;

namespace Benchmarks;

[Mutable]
public sealed record InterpreterContext : Context<InterpreterContext>
{
    public required Program Program { get; init; }
}
