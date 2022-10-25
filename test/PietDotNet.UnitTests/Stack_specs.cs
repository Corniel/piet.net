using PietDotNet.Tests.Tooling;
using Stack = PietDotNet.Stack;

namespace Stack_specs;

public class Enumerator
{
    [Test]
    public void Iterates_from_top_to_bottom()
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
