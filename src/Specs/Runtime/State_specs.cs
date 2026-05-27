using Piet.Runtime;

namespace Specs.Runtime.State_specs;

public class Commands
{
    [Test]
    public void PSH_extends_stack() => StateInfo
        .New([13])
        .PSH(42)
        .Should().Be(new() { Stack = [13, 42] });

    [Test]
    public void POP_reduces_stack() => StateInfo
        .New([13, 42])
        .POP
        .Should().Be(new() { Stack = [13] });

    [Test]
    public void DUP_duplcates_last_item_of_the_stack() => StateInfo
       .New([13, 42])
       .DUP
       .Should().Be(new() { Stack = [13, 42, 42] });

    [Test]
    public void ADD_applies_addition() => StateInfo
        .New([20, 22])
        .ADD
        .Should().Be(new() { Stack = [42] });

    [Test]
    public void SUB_applies_subtraction() => StateInfo
        .New([43, 1])
        .SUB
        .Should().Be(new() { Stack = [42] });

    [Test]
    public void MUL_applies_multiplication() => StateInfo
        .New([14, 3])
        .MUL
        .Should().Be(new() { Stack = [42] });

    [Test]
    public void DIV_applies_division() => StateInfo
        .New([84, 2])
        .DIV
        .Should().Be(new() { Stack = [42] });

    [Test]
    public void MOD_applies_modulation() => StateInfo
        .New([-13, 4])
        .MOD
        .Should().Be(new() { Stack = [3] });

    [Test]
    public void NOT_is_1_for_zero() => StateInfo
        .New([0])
        .NOT
        .Should().Be(new() { Stack = [1] });

    [TestCase(-1)]
    [TestCase(1)]
    [TestCase(17)]
    public void NOT_is_0_for_non_zero(int stack) => StateInfo
        .New([stack])
        .NOT
        .Should().Be(new() { Stack = [0] });

    [TestCase(4, 3)]
    [TestCase(-4, -13)]
    public void GT_is_1_for_when_last_is_smaller(int s, int l) => StateInfo
        .New([s, l])
        .GT_
        .Should().Be(new() { Stack = [1] });

    [TestCase(4, 5)]
    [TestCase(-4, -3)]
    [TestCase(42, 42)]
    public void GT_is_0_for_when_last_is_not_smaller(int s, int l) => StateInfo
        .New([s, l])
        .GT_
        .Should().Be(new() { Stack = [0] });

    [TestCase(CC_DP.LR)]
    [TestCase(CC_DP.LD)]
    [TestCase(CC_DP.RR)]
    [TestCase(CC_DP.RT)]
    public void PT(CC_DP pt)
        => StateInfo.New()[pt].Should().Be(new() { PT = pt });
}
