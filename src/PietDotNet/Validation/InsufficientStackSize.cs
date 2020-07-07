using System;

namespace PietDotNet.Validation
{
    public sealed class InsufficientStackSize : InvalidOperationException
    {
        public InsufficientStackSize() : base("Insufficient stack size.") { }
    }
}
