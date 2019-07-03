using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class HelloWorldArtisticTest : ProgramTestBase
    {
        protected override string Location => "hello_world_artistic.gif";

        [Test]
        public void Run_HelloWorldArtistic_ProducesHelloWorld()
        {
            Interpreter.Run();

            Assert.IsTrue(IO.IsCharOnly);
            Assert.AreEqual("Hello, world!\n", IO.OutString);
        }
    }
}
