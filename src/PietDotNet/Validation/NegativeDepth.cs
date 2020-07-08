using System;

namespace PietDotNet.Validation
{
    public class NegativeDepth : ArgumentOutOfRangeException
    {
        public NegativeDepth() : base("Depth can not be negative.") { }
    }
}
