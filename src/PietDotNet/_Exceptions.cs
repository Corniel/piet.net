namespace PietDotNet;

public sealed class InsufficientStackSize : InvalidOperationException
{
    public InsufficientStackSize() : base("Insufficient stack size.") { }
}

public sealed class InvalidInput : ArgumentException
{
    public InvalidInput() : base("Invalid input.") { }
}

public sealed class NegativeDepth : ArgumentOutOfRangeException
{
    public NegativeDepth() : base("Depth can not be negative.") { }
}

public sealed class Terminated : InvalidOperationException
{
    public Terminated() : base("Program has been terminated.") { }
}

public sealed class UnkownCommand : InvalidOperationException
{
    public UnkownCommand() : base("Unkown command.") { }
}

