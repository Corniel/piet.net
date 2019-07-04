using NUnit.Framework;
using PietDotNet.Tests.Tooling;
using System;
using System.Drawing;

namespace PietDotNet.Tests
{
    public class ProgramTest
    {
        [Test]
        public void OnCanvas_Negative_False()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");
            Assert.False(program.OnCanvas(new Point(-1, 0)));
        }
        [Test]
        public void OnCanvas_HighValue_False()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");
            Assert.False(program.OnCanvas(new Point(0, 1204)));
        }

        [Test]
        public void OnCanvas_RightBottom_True()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");
            Assert.True(program.OnCanvas(new Point(9, 10)));
        }

        [Test]
        public void Value_White_Throws()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");

            //Assert.Throws<InvalidOperationException>(() => program.Value(new Point(8, 9)));
            Assert.Inconclusive("Determine what to do with a white colour block.");
        }

        [Test]
        public void Block_Black_Border()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");

            Assert.AreEqual(ColourBlock.Border,  program.Block(new Point(2, 2)));
        }

        [Test]
        public void Block_NotOnCanvas_Border()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");

            Assert.AreEqual(ColourBlock.Border, program.Block(new Point(-1, 0)));
        }

        [Test]
        public void Value_MinimumColourBlock_1()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");
            var value = program.Block(new Point(0, 5)).Value;
            Assert.AreEqual(1, value);
        }

        [Test]
        public void Value_BiggerolourBlock_1()
        {
            var program = ProgramTestBase.Load("fibonacci_numbers.gif");
            var value = program.Block(new Point(8, 0)).Value;
            Assert.AreEqual(10, value);
        }
    }
}
