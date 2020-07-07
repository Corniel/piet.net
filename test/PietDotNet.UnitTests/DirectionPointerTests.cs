using NUnit.Framework;
using PietDotNet;

namespace DirectionPointerTests
{
    public class Rotate
    {
        [TestCase(DirectionPointer.down, -4, DirectionPointer.down)]
        [TestCase(DirectionPointer.down, +4, DirectionPointer.down)]
        [TestCase(DirectionPointer.down, -5, DirectionPointer.right)]
        [TestCase(DirectionPointer.down, +5, DirectionPointer.left)]
        [TestCase(DirectionPointer.left, +0, DirectionPointer.left)]
        [TestCase(DirectionPointer.left, +3, DirectionPointer.down)]
        public void with_dp_and_steps(DirectionPointer direction, int steps, DirectionPointer expected)
        {
            var rotated = direction.Rotate(steps);
            Assert.AreEqual(expected, rotated);
        }
    }
}
