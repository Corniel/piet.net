using NUnit.Framework;
using PietDotNet;
using PietDotNet.Tests.Tooling;
using PietDotNet.Validation;
using System;

namespace StackCommand
{
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
}
