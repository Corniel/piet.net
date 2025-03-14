namespace Codel_chooser_specs;

public class Switch
{
    [Test]
    public void Left_odd_times_becomes_right()
    {
        Assert.AreEqual(CodelChooser.right, CodelChooser.left.Switch(3));
    }

    [Test]
    public void Left_even_times_stays_left()
    {
        Assert.AreEqual(CodelChooser.left, CodelChooser.left.Switch(4));
    }

    [Test]
    public void Right_odd_times_becomes_left()
    {
        Assert.AreEqual(CodelChooser.left, CodelChooser.right.Switch(3));
    }

    [Test]
    public void Right_even_times_stays_right()
    {
        Assert.AreEqual(CodelChooser.right, CodelChooser.right.Switch(4));
    }
}
