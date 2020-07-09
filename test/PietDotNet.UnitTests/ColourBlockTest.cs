using NUnit.Framework;
using PietDotNet;
using PietDotNet.Tests.Tooling;

namespace ColourBlockTest
{
    public class GetEdge
    {
        [TestCase(0, 3, DirectionPointer.left, /* */ CodelChooser.left)]
        [TestCase(0, 1, DirectionPointer.left, /* */ CodelChooser.right)]
        [TestCase(4, 1, DirectionPointer.right, /**/ CodelChooser.left)]
        [TestCase(4, 3, DirectionPointer.right, /**/ CodelChooser.right)]

        [TestCase(1, 0, DirectionPointer.top, /*  */ CodelChooser.left)]
        [TestCase(3, 0, DirectionPointer.top, /*  */ CodelChooser.right)]
        [TestCase(3, 4, DirectionPointer.down, /* */ CodelChooser.left)]
        [TestCase(1, 4, DirectionPointer.down, /* */ CodelChooser.right)]
        public void From_complex_form(int x, int y, DirectionPointer dp, CodelChooser cc)
        {
            var expected = new Codel(x, y);
            var program = Runner.Load("Snippets.edge.png");
            var block = program.SelectBlock(new Codel(2, 2));
            var pointer = Pointer.Initial.Rotate((int)dp).Switch((int)cc);

            var actual = block.Edge(pointer);

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
        public void From_1x1_form(DirectionPointer dp, CodelChooser cc)
        {
            var expected = new Codel(9, 0);
            var program = Runner.Load("fibonacci_numbers.gif");
            var block = program.SelectBlock(expected);
            var pointer = Pointer.Initial.Rotate((int)dp).Switch((int)cc);

            var actual = block.Edge(pointer);

            Assert.AreEqual(expected, actual);
        }
    }
}
