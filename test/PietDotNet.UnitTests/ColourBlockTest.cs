using NUnit.Framework;
using PietDotNet.Tests.Tooling;
using System.Drawing;

namespace PietDotNet.Tests
{
    public class ColourBlockTest
    {
        [TestCase(0, 3, DirectionPointer.left, /* */ CodelChooser.left)]
        [TestCase(0, 1, DirectionPointer.left, /* */ CodelChooser.right)]
        [TestCase(4, 1, DirectionPointer.right, /**/ CodelChooser.left)]
        [TestCase(4, 3, DirectionPointer.right, /**/ CodelChooser.right)]

        [TestCase(1, 0, DirectionPointer.top, /*  */ CodelChooser.left)]
        [TestCase(3, 0, DirectionPointer.top, /*  */ CodelChooser.right)]
        [TestCase(3, 4, DirectionPointer.down, /* */ CodelChooser.left)]
        [TestCase(1, 4, DirectionPointer.down, /* */ CodelChooser.right)]
        public void Edge_WithComplexForm(int x, int y, DirectionPointer dp, CodelChooser cc)
        {
            var expected = new Point(x, y);
            var program = ProgramTestBase.Load("Snippets.edge.png");
            var block = program.Block(new Point(2, 2));
            var edge = new Edge(dp, cc);

            var actual = block.GetEdge(edge);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(DirectionPointer.left, /* */ CodelChooser.left)]
        [TestCase(DirectionPointer.left, /* */ CodelChooser.right)]
        [TestCase(DirectionPointer.right, /**/ CodelChooser.left)]
        [TestCase(DirectionPointer.right, /**/ CodelChooser.right)]

        [TestCase(DirectionPointer.top, /*  */ CodelChooser.left)]
        [TestCase(DirectionPointer.top, /*  */ CodelChooser.right)]
        [TestCase(DirectionPointer.down, /* */ CodelChooser.left)]
        [TestCase(DirectionPointer.down, /* */ CodelChooser.right)]
        public void Edge_1x1(DirectionPointer dp, CodelChooser cc)
        {
            var expected = new Point(9, 0);
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");
            var block = program.Block(expected);
            var edge = new Edge(dp, cc);

            var actual = block.GetEdge(edge);

            Assert.AreEqual(expected, actual);
        }
    }
}
