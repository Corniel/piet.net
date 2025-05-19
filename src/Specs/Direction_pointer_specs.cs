namespace Direction_pointer_specs;

public class Rotate
{
    [TestCase(DirectionPointer.down, -4, DirectionPointer.down)]
    [TestCase(DirectionPointer.down, +4, DirectionPointer.down)]
    [TestCase(DirectionPointer.down, -5, DirectionPointer.right)]
    [TestCase(DirectionPointer.down, +5, DirectionPointer.left)]
    [TestCase(DirectionPointer.left, +0, DirectionPointer.left)]
    [TestCase(DirectionPointer.left, +3, DirectionPointer.down)]
    public void With_dp_and_steps(DirectionPointer direction, int steps, DirectionPointer rotated)
        => direction.Rotate(steps).Should().Be(rotated);
}
