using PietDotNet.Validation;
using System;
using System.Linq;

namespace PietDotNet
{
    public static class StackCommands
    {
        /// <summary>Pops the top two values off the stack, adds them, and
        /// pushes the result back on the stack.
        /// </summary>
        public static Stack Add(this Stack stack) =>
            stack
            .Pop(2)
            .Push(stack.Second() + stack.First());

        /// <summary>Pops the top two values off the stack, calculates the
        /// second top value minus the top value, and pushes the result back on
        /// the stack.
        /// </summary>
        public static Stack Subtract(this Stack stack) =>
            stack.Pop(2)
            .Push(stack.Second() - stack.First());

        /// <summary>Pops the top two values off the stack, multiplies them,
        /// and pushes the result back on the stack.
        /// </summary>
        public static Stack Multiply(this Stack stack) =>
            stack.Pop(2)
            .Push(stack.Second() * stack.First());

        /// <summary>Pops the top two values off the stack, calculates the
        /// integer division of the second top value by the top value, and
        /// pushes the result back on the stack.
        /// </summary>
        /// <remarks>
        /// If a divide by zero occurs, it is handled as an implementation-
        /// dependent error, though simply ignoring the command is recommended.
        /// </remarks>
        public static Stack Divide(this Stack stack) =>
            stack.Pop(2)
            .Push(stack.Second() / stack.First());

        /// <summary>Pops the top two values off the stack, calculates the
        /// second top value modulo the top value, and pushes the result back
        /// on the stack.
        /// </summary>
        /// <remarks>
        ///  The result has the same sign as the divisor (the top value). If
        ///  the top value is zero, this is a divide by zero error, which is
        ///  handled as an implementation-dependent error, though simply
        ///  ignoring the command is recommended.
        /// </remarks>
        public static Stack Modulo(this Stack stack) =>
            stack.Pop(2)
            .Push(stack.Second().Modulo(stack.First()));

        /// <summary>Replaces the top value of the stack with 0 if it is
        /// non-zero, and 1 if it is zero.
        /// </summary>
        public static Stack Not(this Stack stack) => stack
            .Pop()
            .Push(stack.First() == 0);

        /// <summary> Pops the top two values off the stack, and pushes 1 on to
        /// the stack if the second top value is greater than the top value,
        /// and pushes 0 if it is not greater.
        /// </summary>
        public static Stack Greater(this Stack stack) => stack
            .Pop(2)
            .Push(stack.Second() > stack.First());

        /// <summary> Pushes a copy of the top value on the stack on to the stack.</summary>
        public static Stack Duplicate(this Stack stack) => stack
            .Push(stack.Peek());

        /// <summary>Pops the top two values off the stack and "rolls" the
        /// remaining stack entries to a depth equal to the second value popped,
        /// by a number of rolls equal to the first value popped.
        /// </summary>
        /// <remarks>
        /// A single roll to depth n is defined as burying the top value on the
        /// stack n deep and bringing all values above it up by 1 place. A negative
        /// number of rolls, rolls in the opposite direction. A negative depth is an
        /// error and the command is ignored. If a roll is greater than an
        /// implementation-dependent maximum stack depth, it is handled as an
        /// implementation-dependent error, though simply ignoring the command
        /// is recommended.
        /// </remarks>
        public static Stack Roll(this Stack stack)
        {
            var updated = stack.Pop(2);

            int depth = (int)stack.Second();
            var roll = stack.First();

            if (depth < 0) throw new NegativeDepth();
            if (depth > updated.Count) throw new InsufficientStackSize();
            if (depth == 0 || roll.Modulo(depth) == 0) return updated;

            var rolled = updated.Pop(depth);

            foreach (var value in Enumerable
                .Range(0, depth)
                .Reverse()
                .Select(i => (int)(i + roll).Modulo(depth))
                .Select(i => updated.Pop(i).Peek()))
            {
                rolled = rolled.Push(value);
            }
            return rolled;
        }

        internal static long First(this Stack stack) => stack.Peek();
        internal static long Second(this Stack stack) => stack.Pop().Peek();
    }
}
