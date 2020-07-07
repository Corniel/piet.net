using System;

namespace PietDotNet.Validation
{
    public class InvalidDepth : ArgumentOutOfRangeException
    {
        public InvalidDepth() : base("Depth can not be negative.") { }
    }
}
