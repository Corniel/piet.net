using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class Pi052Test : ProgramTestBase
    {
        protected override string Location => "pi_052.png";

        [Test]
        public void Run_PiWithRIs52Px_ProducesHelloWorld()
        {
            Interpreter.Run();

            Assert.AreEqual(new long[] { 31_405 }, IO.OutInts);
        }
    }
}
