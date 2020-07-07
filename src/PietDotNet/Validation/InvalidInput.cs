using System;

namespace PietDotNet.Validation
{
    public class InvalidInput : ArgumentException
    {
        public InvalidInput() : base("Invalid input.") { }
    }
}
