namespace Codel_chooser_specs;

public class Switch
{
    [TestCase(1)]
    [TestCase(3)]
    public void Left_odd_times_becomes_right(int times)
        => CodelChooser.left.Switch(times).Should().Be(CodelChooser.right);

    [TestCase(2)]
    [TestCase(4)]
    public void Left_even_times_stays_same(int times)
        => CodelChooser.left.Switch(times).Should().Be(CodelChooser.left);

    [TestCase(1)]
    [TestCase(3)]
    public void Right_odd_times_becomes_left(int times)
        => CodelChooser.right.Switch(times).Should().Be(CodelChooser.left);

    [TestCase(2)]
    [TestCase(4)]
    public void Right_even_times_stays_same(int times)
        => CodelChooser.right.Switch(times).Should().Be(CodelChooser.right);
}
