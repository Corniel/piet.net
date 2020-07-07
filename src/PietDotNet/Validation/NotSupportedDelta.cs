using System;

namespace PietDotNet.Validation
{
    public class NotSupportedDelta : InvalidOperationException
    {
        public NotSupportedDelta() : base("Not supported delta.") { }
    }
}
