using Piet.Runtime;
using Piet.Syntax;

namespace Specs.Syntax.Codel_specs;

public class Next
{
    [TestCase(+0, -1, CC_DP.LT)]
    [TestCase(+1, +0, CC_DP.LR)]
    [TestCase(+0, +1, CC_DP.LD)]
    [TestCase(-1, +0, CC_DP.LL)]
    public void With_dp(int x, int y, CC_DP pt)
        => new Codel(0, 0).Next(pt).Should().Be(new Codel(x, y));
}
