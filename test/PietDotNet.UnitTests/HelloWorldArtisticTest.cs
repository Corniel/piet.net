using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class HelloWorldArtisticTest : ProgramTestBase
    {
        protected override string Location => "hello_world_artistic.gif";

        [Test]
        public void Execute_ProducesHelloWorld()
        {
            Interpreter.Execute();

            var actual = new string(IO.OutChrs.ToArray());
            Assert.AreEqual("Hello, World!", actual);
        }
    }
}
