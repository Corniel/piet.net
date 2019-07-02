using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PietDotNet.Tests
{
    public class CodelTest
    {
        [Test]
        public void All_20Codels_WithUniqueColours()
        {
            Assert.AreEqual(20, Codel.All.Count);
            Assert.AreEqual(20, new HashSet<Color>(Codel.All.Select(codel => codel.Colour)).Count, "All colours should be different too.");
        }

        [Test]
        public void Minus_WithBlack_Throws()
        {
            Assert.Throws<InvalidOperationException>(() => { var delta = Codel.Black - Codel.Green; });
        }

        [Test]
        public void Minus_WithWhite_Throws()
        {
            Assert.Throws<InvalidOperationException>(() => { var delta = Codel.Red - Codel.White; });
        }

        [Test]
        public void Minus_RedMinusDarkRed_Pop()
        {
            var delta = Codel.Red - Codel.RedDark;
            Assert.AreEqual(Delta.Pop, delta);
        }

        [Test]
        public void ToString_YellowLight_Descriptive()
        {
            var str = Codel.YellowLight.ToString();
            Assert.AreEqual("#FFFFC0 light yellow", str);
        }

        [Test]
        public void From_NotMatchingColour_Null()
        {
            var colour = Color.Brown;
            var codel = Codel.From(colour);

            Assert.Null(codel);
        }

        [Test]
        public void From_MatchingColour_Matched()
        {
            var colour = Color.FromArgb(255, 255, 255);
            var codel = Codel.From(colour);

            Assert.AreEqual(Codel.White, codel);
        }
    }
}
