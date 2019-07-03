using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class HelloWorldTest : ProgramTestBase
    {
        protected override string Location => "hello_world.png";

        [Test]
        public void Run_HelloWorld_ProducesHelloWorld()
        {
            Interpreter.Run();

            Assert.IsTrue(IO.IsCharOnly);
            Assert.AreEqual("Hello, World!", IO.OutString);
        }
    }
}
