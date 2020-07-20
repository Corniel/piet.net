using System;

namespace PietDotNet
{
    public sealed class InsufficientStackSize : InvalidOperationException
    {
        public InsufficientStackSize() : base("Insufficient stack size.") { }
    }
    public class InvalidInput : ArgumentException
    {
        public InvalidInput() : base("Invalid input.") { }
    }
    public class NegativeDepth : ArgumentOutOfRangeException
    {
        public NegativeDepth() : base("Depth can not be negative.") { }
    }
    public class Terminated : ApplicationException
    {
        public Terminated() : base("Program has been terminated.") { }
    }

    public class UnkownCommand : InvalidOperationException
    {
        public UnkownCommand() : base("Unkown command.") { }
    }

}
