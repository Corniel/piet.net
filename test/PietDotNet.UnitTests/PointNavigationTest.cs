using NUnit.Framework;
using System.Drawing;

namespace PietDotNet.Tests
{
    public class PointNavigationTest
    {
        [TestCase(+0, -1, DirectionPointer.top)]
        [TestCase(+1, +0, DirectionPointer.right)]
        [TestCase(+0, +1, DirectionPointer.down)]
        [TestCase(-1, +0, DirectionPointer.left)]
        public void Next(int x, int y, DirectionPointer dp)
        {
            var expected = new Point(x, y);
            var next = new Point(0, 0).Next(dp);
            Assert.AreEqual(expected, next);
        }
    }
}
