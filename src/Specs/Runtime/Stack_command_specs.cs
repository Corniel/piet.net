namespace Specs.Runtime.Stack_command_specs;

public class Pop
{
    [Test]
    public void Empty_stack_has_insufficient_stack_size() => Stack
        .Empty
        .Pop(out _)
        .Should().BeEmpty();

    [Test]
    public void Removes_top_item_from_not_empty_stack() => Stack
        .Empty
        .Push(3)
        .Push(17)
        .Pop(out _)
        .Should().Be(3);
}

public class Push
{
    [Test]
    public void integer_adds_value_to_top() => Stack
        .Empty
        .Push(42)
        .Should().Be(42);
}

public class Add
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Add()
        .Should().Be(42);

    [Test]
    public void pops_top_values_and_pushes_sum() => Stack
        .Empty
        .Push(17)
        .Push(25)
        .Add()
        .Should().Be(17 + 25);
}

public class Subtract
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Subtract()
        .Should().Be(42);

    [Test]
    public void pops_top_values_and_pushes_subtraction() => Stack
        .Empty
        .Push(17)
        .Push(25)
        .Subtract()
        .Should().Be(17 - 25);
}

public class Multiply
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Multiply()
        .Should().Be(42);

    [Test]
    public void pops_top_values_and_pushes_product() => Stack
        .Empty
        .Push(17)
        .Push(25)
        .Multiply()
        .Should().Be(17 * 25);
}

public class Divide
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Divide()
        .Should().Be(42);

    [Test]
    public void by_zero_is_not_allowed() => Stack
        .Empty
        .Push(42)
        .Push(0)
        .Divide()
        .Should().Be(0, 42);

    [Test]
    public void pops_top_values_and_pushes_division() => Stack
        .Empty
        .Push(42)
        .Push(14)
        .Divide()
        .Should().Be(42 / 14);
}

public class Modulo
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Modulo()
        .Should().Be(42);

    [Test]
    public void with_zero_is_not_allowed() => Stack
        .Empty
        .Push(42)
        .Push(0)
        .Modulo()
        .Should().Be(0, 42);

    [Test]
    public void with_postive_value_pops_top_values_and_pushes_modulo() => Stack
        .Empty
        .Push(42)
        .Push(5)
        .Modulo()
        .Should().Be(2);

    [Test]
    public void with_negative_value_pops_top_values_and_pushes_modulo() => Stack
        .Empty
        .Push(42)
        .Push(-11)
        .Modulo()
        .Should().Be(9);
}

public class Not
{
    [Test]
    public void with_zero_items_is_has_insufficient_stack_size() => Stack
        .Empty
        .Not()
        .Should().BeEmpty();

    [Test]
    public void top_value_0_becomes_1() => Stack
        .Empty
        .Push(0)
        .Not()
        .Should().Be(1);

    [Test]
    public void top_value_not_zero_becomes_0([Range(1, 10)] int value) => Stack
        .Empty
        .Push(value)
        .Not()
        .Should().Be(0);
}

public class Greater
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Greater()
        .Should().Be(42);

    [Test]
    public void pops_top_values_and_pushes_1_as_second_was_greater() => Stack
        .Empty
        .Push(42)
        .Push(17)
        .Greater()
        .Should().Be(1);

    [Test]
    public void pops_top_values_and_pushes_0_as_second_was_not_greater() => Stack
        .Empty
        .Push(42)
        .Push(42)
        .Greater()
        .Should().Be(0);
}

public class Duplicate
{
    [Test]
    public void with_zero_items_is_has_insufficient_stack_size() => Stack
        .Empty
        .Duplicate()
        .Should().BeEmpty();

    [Test]
    public void adds_copy_top_value_to_top() => Stack
        .Empty
        .Push(42)
        .Duplicate()
        .Should().Be(42, 42);
}

public class Roll
{
    [Test]
    public void with_one_item_has_insufficient_stack_size() => Stack
        .Empty
        .Push(42)
        .Roll()
        .Should().Be(42);

    [Test]
    public void With_negative_depth_is_not_allowed() => Stack
        .Empty
        .Push(42)
        .Push(-1)
        .Push(1)
        .Roll()
        .Should().Be(1, -1, 42);

    [Test]
    public void With_depth_greater_then_stack_size_is_not_allowed() => Stack
        .Empty
        .Push(42)
        .Push(2)
        .Push(1)
        .Roll()
        .Should().Be(1, 2, 42);

    [Test]
    public void With_zero_depth_keeps_same_order() => Stack
        .Empty
        .Push(42)
        .Push(17)
        .Push(0)
        .Push(1)
        .Roll()
        .Should().Be(17, 42);

    [Test]
    public void With_zero_rolls_keeps_same_order() => Stack
        .Empty
        .Push(42)
        .Push(17)
        .Push(2)
        .Push(0)
        .Roll()
        .Should().Be(17, 42);

    [Test]
    public void With_all_rolls_moves_items() => Stack
        .Empty
        .Push(69)
        .Push(17)
        .Push(42)
        .Push(3)
        .Push(1)
        .Roll()
        .Should().Be(17, 69, 42);

    [TestCase(+1, 14, 13, 12, 11, 15, 2017)]
    [TestCase(+2, 13, 12, 11, 15, 14, 2017)]
    [TestCase(+3, 12, 11, 15, 14, 13, 2017)]
    [TestCase(+4, 11, 15, 14, 13, 12, 2017)]
    [TestCase(-1, 11, 15, 14, 13, 12, 2017)]
    public void Rolls_selection(int roll, params long[] stack) => Stack
        .Empty
        .Push(2017)
        .Push(11)
        .Push(12)
        .Push(13)
        .Push(14)
        .Push(15)
        .Push(5)
        .Push(roll)
        .Roll()
        .Should().Be(stack);
}
