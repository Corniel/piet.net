using NUnit.Framework;
using PietDotNet.IO;
using PietDotNet.Tests.Tooling;
using System;
using System.IO;
using System.Linq;

namespace ProgramBinaryTests
{
    public class Load
    {
        [Test]
        public void unknown()
        {
            long size = 1;
            var steps = 0;

            while(steps++ < 14)
            {
                checked { size *= 20; }
                var str = size.ToString("X2");
                Console.WriteLine($"steps: {steps}, size: {str}, length: {str.Length}");
            }
        }
    }

    public class Storage
    {
        [Test]
        public void Program_should_have_dimensions_and_colours()
        {
            var program = Runner.Load("tetris.png");

            using var stream = new MemoryStream();
            program.Save(stream);

            Assert.AreEqual(188, stream.Length);

            stream.Position = 0;

            var reloaded = Binary.Load(stream);
            Assert.AreEqual(program.Width, reloaded.Width);
            Assert.AreEqual(program.Height, reloaded.Height);
            CollectionAssert.AreEqual(program.ToArray(), reloaded.ToArray());
        }
    }
}
