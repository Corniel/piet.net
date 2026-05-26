namespace Piet.Runtime;

public sealed class InsufficientStackSize : InvalidOperationException
{
    public InsufficientStackSize() : base("Insufficient stack size.") { }
}

public sealed class InvalidInput : ArgumentException
{
    public InvalidInput() : base("Invalid input.") { }
}

public sealed class NegativeDepth : InvalidOperationException
{
    public NegativeDepth() : base("Depth can not be negative.") { }
}
