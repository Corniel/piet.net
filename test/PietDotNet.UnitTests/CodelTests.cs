using NUnit.Framework;
using PietDotNet;

namespace CodelTests
{
    public class Next
    {
        [TestCase(+0, -1, DirectionPointer.top)]
        [TestCase(+1, +0, DirectionPointer.right)]
        [TestCase(+0, +1, DirectionPointer.down)]
        [TestCase(-1, +0, DirectionPointer.left)]
        public void with_dp(int x, int y, DirectionPointer dp)
        {
            var expected = new Codel(x, y);
            var next = new Codel(0, 0).Next(dp);
            Assert.AreEqual(expected, next);
        }
    }
}
