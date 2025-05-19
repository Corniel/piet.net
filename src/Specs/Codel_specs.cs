namespace Codel_specs;

public class Next
{
    [TestCase(+0, -1, DirectionPointer.top)]
    [TestCase(+1, +0, DirectionPointer.right)]
    [TestCase(+0, +1, DirectionPointer.down)]
    [TestCase(-1, +0, DirectionPointer.left)]
    public void With_dp(int x, int y, DirectionPointer dp)
        => new Codel(0, 0).Next(dp).Should().Be(new Codel(x, y));

    [TestCase((DirectionPointer)4)]
    public void With_undefined_direction_pointer_is_not_allowed(DirectionPointer undefined)
        => undefined.Invoking(u => new Codel(1, 1).Next(u))
        .Should().Throw<ArgumentOutOfRangeException>();
}
