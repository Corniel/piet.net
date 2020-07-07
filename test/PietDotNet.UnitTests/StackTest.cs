using NUnit.Framework;
using PietDotNet.Tests.Tooling;

namespace PietDotNet.Tests
{
    public class StackTest
    {
        [Test]
        public void Enumerator_iterates_from_top_to_bottom()
        {
            var stack = Stack.Empty
                .Push(0)
                .Push(1)
                .Push(2)
                .Push(3)
                .Push(4)
                .Push(5);

            StackAssert.AreEqual(stack, 5, 4, 3, 2, 1, 0);
        }
    }
}
