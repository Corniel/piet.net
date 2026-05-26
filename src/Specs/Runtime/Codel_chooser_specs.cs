using Piet.Runtime;

namespace Specs.Runtime.Codel_chooser_specs;

public class Switch
{
    [TestCase(-17)]
    [TestCase(1)]
    [TestCase(3)]
    public void Left_odd_times_becomes_right(int times)
        => CC_DP.LT.Switch(times).Should().Be(CC_DP.RT);

    [TestCase(-42)]
    [TestCase(2)]
    [TestCase(4)]
    public void Left_even_times_stays_same(int times)
        => CC_DP.LT.Switch(times).Should().Be(CC_DP.LT);

    [TestCase(-17)]
    [TestCase(1)]
    [TestCase(3)]
    public void Right_odd_times_becomes_left(int times)
        => CC_DP.RT.Switch(times).Should().Be(CC_DP.LT);

    [TestCase(-42)]
    [TestCase(2)]
    [TestCase(4)]
    public void Right_even_times_stays_same(int times)
        => CC_DP.RT.Switch(times).Should().Be(CC_DP.RT);
}
