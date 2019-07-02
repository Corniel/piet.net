using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class HelloWorldBigTest : ProgramTestBase
    {
        protected override string Location => "hello_world_big.gif";
        public override int CodelSize => 4;

        [Test]
        public void Execute_ProducesHelloWorld()
        {
            Interpreter.Execute();

            var actual = new string(IO.OutChrs.ToArray());
            Assert.AreEqual("hello world!\n", actual);
        }
    }
}
