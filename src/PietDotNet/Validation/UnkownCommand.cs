using System;

namespace PietDotNet.Validation
{
    public class UnkownCommand : InvalidOperationException
    {
        public UnkownCommand() : base("Unkown command.") { }
    }
}
