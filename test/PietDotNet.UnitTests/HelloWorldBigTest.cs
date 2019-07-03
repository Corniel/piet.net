using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class HelloWorldBigTest : ProgramTestBase
    {
        protected override string Location => "hello_world_big.gif";
        public override int CodelSize => 4;

        [Test]
        public void Run_HelloWorldBig_ProducesHelloWorld()
        {
            Interpreter.Run();

            Assert.IsTrue(IO.IsCharOnly);
            Assert.AreEqual("hello world!\n", IO.OutString);
        }
    }
}
