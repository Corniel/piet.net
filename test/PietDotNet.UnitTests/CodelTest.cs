using NUnit.Framework;
using PietDotNet;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CodelTests
{
    public class All
    {
        [Test]
        public void _20_unique_colours_exist()
        {
            Assert.AreEqual(20, Codel.All.Count);
            Assert.AreEqual(20, new HashSet<Color>(Codel.All.Select(codel => codel.Colour)).Count, "All colours should be different too.");
        }
    }
    public class Subtract
    {
        [Test]
        public void With_Black_is_invalid_operation()
        {
            Assert.Throws<InvalidOperationException>(() => { var delta = Codel.Black - Codel.Green; });
        }

        [Test]
        public void With_White_is_invalid_operation()
        {
            Assert.Throws<InvalidOperationException>(() => { var delta = Codel.Red - Codel.White; });
        }

        [Test]
        public void Red_and_RedDark_is_Pop()
        {
            Assert.AreEqual(Command.Pop, Codel.Red - Codel.RedDark);
        }

        [Test]
        public void Red_and_GreenLight_is_Roll()
        {
            Assert.AreEqual(Command.Roll, Codel.Red - Codel.GreenLight);
        }
    }

    public class ToString
    {
        [Test]
        public void Discribes_RGB_and_display_name()
        {
            var str = Codel.YellowLight.ToString();
            Assert.AreEqual("#FFFFC0 light yellow", str);
        }
    }

    public class Factory
    {
        [Test]
        public void From_not_matching_colour_returns_null()
        {
            var colour = Color.Brown;
            var codel = Codel.From(colour);

            Assert.Null(codel);
        }

        [Test]
        public void From_matching_colour_returns_codel_with_matching_color()
        {
            var colour = Color.FromArgb(255, 255, 255);
            var codel = Codel.From(colour);

            Assert.AreEqual(Codel.White, codel);
        }
    }
}
