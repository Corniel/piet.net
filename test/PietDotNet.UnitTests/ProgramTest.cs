using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class ProgramTest
    {
        [Test]
        public void OnCanvas_Negative_False()
        {
            var program = Runner.Load("fibonacci_numbers.gif");
            Assert.False(program.OnCanvas(new Codel(-1, 0)));
        }

        [Test]
        public void OnCanvas_HighValue_False()
        {
            var program = Runner.Load("fibonacci_numbers.gif");
            Assert.False(program.OnCanvas(new Codel(0, 1204)));
        }

        [Test]
        public void OnCanvas_RightBottom_True()
        {
            var program = Runner.Load("fibonacci_numbers.gif");
            Assert.True(program.OnCanvas(new Codel(9, 10)));
        }

        [Test]
        public void Value_White_IsReturned()
        {
            var program = Runner.Load("fibonacci_numbers.gif");
            var value = program.SelectBlock(new Codel(8, 9)).Value;
            Assert.AreEqual(8, value);
        }

        [Test]
        public void Block_Black_Border()
        {
            var program = Runner.Load("fibonacci_numbers.gif");

            Assert.AreEqual(ColourBlock.Border,  program.SelectBlock(new Codel(2, 2)));
        }

        [Test]
        public void Block_NotOnCanvas_Border()
        {
            var program = Runner.Load("fibonacci_numbers.gif");

            Assert.AreEqual(ColourBlock.Border, program.SelectBlock(new Codel(-1, 0)));
        }

        [Test]
        public void Value_MinimumColourBlock_1()
        {
            var program = Runner.Load("fibonacci_numbers.gif");
            var value = program.SelectBlock(new Codel(0, 5)).Value;
            Assert.AreEqual(1, value);
        }

        [Test]
        public void Value_BiggerolourBlock_1()
        {
            var program = Runner.Load("fibonacci_numbers.gif");
            var value = program.SelectBlock(new Codel(8, 0)).Value;
            Assert.AreEqual(10, value);
        }
    }
}
