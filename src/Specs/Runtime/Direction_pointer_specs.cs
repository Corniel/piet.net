using Piet.Runtime;

namespace Specs.Runtime.sDirection_pointer_specs;

public class Rotate
{
    [TestCase(CC_DP.LD, -4, CC_DP.LD)]
    [TestCase(CC_DP.LD, +4, CC_DP.LD)]
    [TestCase(CC_DP.LD, -5, CC_DP.LR)]
    [TestCase(CC_DP.LD, +5, CC_DP.LL)]
    [TestCase(CC_DP.LL, +0, CC_DP.LL)]
    [TestCase(CC_DP.LL, +3, CC_DP.LD)]
    [TestCase(CC_DP.RD, -4, CC_DP.RD)]
    [TestCase(CC_DP.RD, +4, CC_DP.RD)]
    [TestCase(CC_DP.RD, -5, CC_DP.RR)]
    [TestCase(CC_DP.RD, +5, CC_DP.RL)]
    [TestCase(CC_DP.RL, +0, CC_DP.RL)]
    [TestCase(CC_DP.RL, +3, CC_DP.RD)]
    public void With_dp_and_steps(CC_DP direction, int steps, CC_DP rotated)
        => direction.Rotate(steps).Should().Be(rotated);
}
