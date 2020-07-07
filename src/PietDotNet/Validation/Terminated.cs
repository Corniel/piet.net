using System;

namespace PietDotNet.Validation
{
    public class Terminated : ApplicationException
    {
        public Terminated() : base("Program has been terminated.") { }
    }
}
