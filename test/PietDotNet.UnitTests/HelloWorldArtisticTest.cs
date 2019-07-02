using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class HelloWorldArtisticTest : ProgramTestBase
    {
        protected override string Location => "hello_world_artistic.gif";

        [Test, Ignore("Test runs infinitely at the moment. TODO: Fix")]
        public void Execute_HelloWorldArtistic_ProducesHelloWorld()
        {
            Interpreter.Execute();

            Assert.IsTrue(IO.IsCharOnly);
            Assert.AreEqual("Hello, World!", IO.OutString);
        }
    }
}
