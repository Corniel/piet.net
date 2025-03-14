using PietDotNet.Tests.Tooling;
using Stack = PietDotNet.Stack;

namespace Stack_command_specs;

public class Pop
{
    [Test]
    public void Empty_stack_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Pop());
    }

    [Test]
    public void Removes_top_item_from_not_empty_stack()
    {
        var stack = Stack.Empty.Push(3).Push(17).Pop();
        StackAssert.AreEqual(stack, 3);
    }
}

public class Peek
{
    [Test]
    public void Empty_stack_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Peek());
    }

    [Test]
    public void Returns_top_value_on_not_empty_stack()
    {
        var stack = Stack.Empty.Push(3).Push(17);
        Assert.AreEqual(17, stack.Peek());
        StackAssert.AreEqual(stack, 17, 3);
    }
}

public class Push
{
    [Test]
    public void integer_adds_value_to_top()
    {
        var stack = Stack
            .Empty
            .Push(42);

        StackAssert.AreEqual(stack, 42);
    }

    [Test]
    public void true_adds_1_to_top()
    {
        var stack = Stack
            .Empty
            .Push(true);

        StackAssert.AreEqual(stack, 1);
    }

    [Test]
    public void false_adds_0_to_top()
    {
        var stack = Stack
            .Empty
            .Push(false);

        StackAssert.AreEqual(stack, 0);
    }
}

public class Add
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Add());
    }

    [Test]
    public void pops_top_values_and_pushes_sum()
    {
        var stack = Stack
            .Empty
            .Push(17)
            .Push(25)
            .Add();

        StackAssert.AreEqual(stack, 42);
    }
}

public class Subtract
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Subtract());
    }

    [Test]
    public void pops_top_values_and_pushes_subtraction()
    {
        var stack = Stack
            .Empty
            .Push(17)
            .Push(25)
            .Subtract();

        StackAssert.AreEqual(stack, -8);
    }
}

public class Multiply
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Multiply());
    }

    [Test]
    public void pops_top_values_and_pushes_product()
    {
        var stack = Stack
            .Empty
            .Push(17)
            .Push(25)
            .Multiply();

        StackAssert.AreEqual(stack, 425);
    }
}
public class Divide
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Divide());
    }

    [Test]
    public void by_zero_is_not_allowed()
    {
        Assert.Catch<DivideByZeroException>(() => Stack.Empty.Push(42).Push(0).Divide());
    }

    [Test]
    public void pops_top_values_and_pushes_division()
    {
        var stack = Stack
            .Empty
            .Push(42)
            .Push(14)
            .Divide();

        StackAssert.AreEqual(stack, 3);
    }
}
public class Modulo
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Modulo());
    }

    [Test]
    public void with_zero_is_not_allowed()
    {
        Assert.Catch<DivideByZeroException>(() => Stack.Empty.Push(42).Push(0).Modulo());
    }

    [Test]
    public void with_postive_value_pops_top_values_and_pushes_modulo()
    {
        var stack = Stack
            .Empty
            .Push(-42)
            .Push(5)
            .Modulo();

        StackAssert.AreEqual(stack, 3);
    }

    [Test]
    public void with_negative_value_pops_top_values_and_pushes_modulo()
    {
        var stack = Stack
            .Empty
            .Push(42)
            .Push(-11)
            .Modulo();

        StackAssert.AreEqual(stack, 9);
    }
}

public class Not
{
    [Test]
    public void with_zero_items_is_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Not());
    }

    [Test]
    public void top_value_0_becomes_1()
    {
        var stack = Stack
            .Empty
            .Push(0)
            .Not();

        StackAssert.AreEqual(stack, 1);
    }

    [Test]
    public void top_value_not_zero_becomes_0()
    {
        var stack = Stack
            .Empty
            .Push(42)
            .Not();

        StackAssert.AreEqual(stack, 0);
    }
}

public class Greater
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Greater());
    }

    [Test]
    public void pops_top_values_and_pushes_1_as_second_was_greater()
    {
        var stack = Stack
            .Empty
            .Push(42)
            .Push(17)
            .Greater();

        StackAssert.AreEqual(stack, 1);
    }

    [Test]
    public void pops_top_values_and_pushes_0_as_second_was_not_greater()
    {
        var stack = Stack
            .Empty
            .Push(42)
            .Push(42)
            .Greater();

        StackAssert.AreEqual(stack, 0);
    }
}

public class Duplicate
{
    [Test]
    public void with_zero_items_is_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Duplicate());
    }

    [Test]
    public void adds_copy_top_value_to_top()
    {
        var stack = Stack
             .Empty
             .Push(42)
             .Duplicate();

        StackAssert.AreEqual(stack, 42, 42);
    }
}

public class Roll
{
    [Test]
    public void with_one_item_has_insufficient_stack_size()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty.Push(42).Roll());
    }

    [Test]
    public void With_negative_depth_is_not_allowed()
    {
        Assert.Catch<NegativeDepth>(() => Stack.Empty
            .Push(42)
            .Push(-1)
            .Push(1)
            .Roll());
    }

    [Test]
    public void With_depth_greater_then_stack_size_is_not_allowed()
    {
        Assert.Catch<InsufficientStackSize>(() => Stack.Empty
            .Push(42)
            .Push(2)
            .Push(1)
            .Roll());
    }

    [Test]
    public void With_zero_depth_keeps_same_order()
    {
        var stack = Stack.Empty
             .Push(42)
             .Push(17)
             .Push(0)
             .Push(1)
             .Roll();

        StackAssert.AreEqual(stack, 17, 42);
    }

    [Test]
    public void With_zero_rolls_keeps_same_order()
    {
        var stack = Stack.Empty
             .Push(42)
             .Push(17)
             .Push(2)
             .Push(0)
             .Roll();

        StackAssert.AreEqual(stack, 17, 42);
    }


    [Test]
    public void With_positive_rolls_moves_items_within_depth_range_up()
    {
        var stack = Stack
            .Empty
            .Push(666)
            .Push(69)
            .Push(17)
            .Push(42)
            .Push(3)
            .Push(1)
            .Roll();

        StackAssert.AreEqual(stack, 17, 69, 42, 666);
    }

    [Test]
    public void With_negative_rolls_moves_items_within_depth_range_down()
    {
        var stack = Stack
            .Empty
            .Push(666)
            .Push(69)
            .Push(17)
            .Push(42)
            .Push(3)
            .Push(-1)
            .Roll();

        StackAssert.AreEqual(stack, 69, 42, 17, 666);
    }
}
