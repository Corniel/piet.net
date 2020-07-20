using NUnit.Framework;
using PietDotNet;

namespace Direction_pointer_specs
{
    public class Rotate
    {
        [TestCase(DirectionPointer.down, -4, DirectionPointer.down)]
        [TestCase(DirectionPointer.down, +4, DirectionPointer.down)]
        [TestCase(DirectionPointer.down, -5, DirectionPointer.right)]
        [TestCase(DirectionPointer.down, +5, DirectionPointer.left)]
        [TestCase(DirectionPointer.left, +0, DirectionPointer.left)]
        [TestCase(DirectionPointer.left, +3, DirectionPointer.down)]
        public void With_dp_and_steps(DirectionPointer direction, int steps, DirectionPointer expected)
        {
            var rotated = direction.Rotate(steps);
            Assert.AreEqual(expected, rotated);
        }
    }
}
