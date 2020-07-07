using NUnit.Framework;

namespace PietDotNet.Tests
{
    public class DirectionPointerTest
    {
        [TestCase(DirectionPointer.down, -4, DirectionPointer.down)]
        [TestCase(DirectionPointer.down, +4, DirectionPointer.down)]
        [TestCase(DirectionPointer.down, -5, DirectionPointer.right)]
        [TestCase(DirectionPointer.down, +5, DirectionPointer.left)]
        [TestCase(DirectionPointer.left, +0, DirectionPointer.left)]
        [TestCase(DirectionPointer.left, +3, DirectionPointer.down)]
        public void Rotate(DirectionPointer direction, int rotate, DirectionPointer expected)
        {
            var rotated = direction.Rotate(rotate);
            Assert.AreEqual(expected, rotated);
        }
    }
}
