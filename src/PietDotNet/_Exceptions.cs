using System.Runtime.Serialization;

namespace PietDotNet;

[Serializable]
public sealed class InsufficientStackSize : InvalidOperationException
{
    public InsufficientStackSize() : base("Insufficient stack size.") { }
    private InsufficientStackSize(SerializationInfo info, StreamingContext context) : base(info, context){ }
}
[Serializable]
public sealed class InvalidInput : ArgumentException
{
    public InvalidInput() : base("Invalid input.") { }
    private InvalidInput(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
[Serializable]
public sealed class NegativeDepth : ArgumentOutOfRangeException
{
    public NegativeDepth() : base("Depth can not be negative.") { }
    private NegativeDepth(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
[Serializable]
public sealed class Terminated : ApplicationException
{
    public Terminated() : base("Program has been terminated.") { }
    private Terminated(SerializationInfo info, StreamingContext context) : base(info, context) { }
}

[Serializable]
public sealed class UnkownCommand : InvalidOperationException
{
    public UnkownCommand() : base("Unkown command.") { }
    private UnkownCommand(SerializationInfo info, StreamingContext context) : base(info, context) { }
}

