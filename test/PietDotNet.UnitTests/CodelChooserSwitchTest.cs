using NUnit.Framework;

namespace PietDotNet.Tests
{
    public class CodelChooserSwitchTest
    {
        [Test]
        public void Switch_left_odd_times_becomes_right()
        {
            Assert.AreEqual(CodelChooser.right, CodelChooser.left.Switch(3));
        }

        [Test]
        public void Switch_left_even_times_stays_left()
        {
            Assert.AreEqual(CodelChooser.left, CodelChooser.left.Switch(4));
        }

        [Test]
        public void Switch_right_odd_times_becomes_left()
        {
            Assert.AreEqual(CodelChooser.left, CodelChooser.right.Switch(3));
        }

        [Test]
        public void Switch_right_even_times_stays_right()
        {
            Assert.AreEqual(CodelChooser.right, CodelChooser.right.Switch(4));
        }
    }
}
