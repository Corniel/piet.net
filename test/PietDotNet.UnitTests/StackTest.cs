using NUnit.Framework;
using System;

namespace PietDotNet.Tests
{
    public class StackTest
    {
        [TestCase(1, true)]
        [TestCase(0, false)]
        public void Push_Boolean(long expected, bool value)
        {
            var stack = new Stack();
            stack.Push(value);
            Assert.AreEqual(expected, stack.Peek());
        }

        [Test]
        public void Roll_2WithDepth4_HaveBeenRolled()
        {
            var stack = new Stack();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Roll(2, 4);

            var expected = new long[] { 3, 2, 5, 4, 1, 0 };

            CollectionAssert.AreEqual(expected, stack);
        }

        [Test]
        public void Enumerator_AreEqual()
        {
            var stack = new Stack();
            stack.Push(0);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            var expected = new long[] { 5, 4, 3, 2, 1, 0 };

            CollectionAssert.AreEqual(expected, stack);
        }

        [Test]
        public void StackOverflow_ToBig()
        {
            var stack = new Stack(1);
            stack.Push(17);

            Assert.Throws<StackOverflowException>(() => stack.Push(666));
        }
    }
}
