using Microsoft.Extensions.Logging;
using PietDotNet.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PietDotNet
{
    public class Interpreter
    {
        private readonly IInOut io;
        private readonly ILogger logger;

        private readonly Stack stack = new Stack();

        private CodelChooser cc;
        private DirectionPointer dp;
        private Point point;
        private Codel prev;
        private Codel curr;
        
        public Interpreter(IInOut io = null, ILogger logger = null)
        {
            this.io = io ?? new ConsoleInOut();
            this.logger = logger ?? new ConsoleLogger();
        }

        public void Execute(Program program)
        {
            Guard.NotNull(program, nameof(program));

            stack.Clear();
            cc = default;
            dp = default;

            point = new Point(0, 0);

            prev = program[point];
            curr = prev;

            while (true)
            {
                Traverse(program);

                var delta = curr - prev;
                Execute(delta);
            }
        }

        private void Traverse(Program program)
        {
            // The interpreter finds the edge of the current colour block which is furthest in the direction of the DP. (This edge may be disjoint if the block is of a complex shape.)
            while (curr == prev)
            {
                var pt = point.Next(dp);
                curr = program[pt];

                if (curr.IsBlack)
                {
                    // rotate ect.
                    dp = dp.Rotate(1);
                    curr = prev;
                }
                else
                {
                    point = pt;
                }
            }
        }

        private void Execute(CodelDelta delta)
        {
            if (commands.TryGetValue(delta, out var command))
            {
                command.Invoke(this);
            }
            else
            {
                throw new InvalidOperationException($"Could not execute delta {delta}.");
            }
    }

        private void None() { /*Do nothing */ }

        /// <summary>Pushes the value of the colour block just exited on to the stack.</summary>
        /// <remarks>
        ///  Note that values of colour blocks are not automatically pushed on to the stack - this push operation must be explicitly carried out.
        /// </remarks>
        private void Push()
        {
            var value = 1;
            stack.Push(value);

            logger.LogDebug(Log.Executed(nameof(Push), value));
        }

        /// <summary>Pops the top value off the stack and discards it.</summary>
        private void Pop()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Pop), stack));
                return;
            }

            var value = stack.PopInt();

            logger.LogDebug(Log.Executed(nameof(Pop), value));
        }

        /// <summary>Pops the top two values off the stack, adds them, and pushes the result back on the stack.</summary>
        private void Add()
        {
            if(!stack.HasMultiple())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Add), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second + first;
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Add), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value minus the top value, and pushes the result back on the stack.</summary>
        private void Subtract()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Subtract), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second - first;
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Subtract), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, multiplies them, and pushes the result back on the stack.</summary>
        private void Multiply()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Multiply), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second * first;
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Multiply), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, calculates the integer division of the second top value by the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        /// If a divide by zero occurs, it is handled as an implementation-dependent error, though simply ignoring the command is recommended.
        /// </remarks>
        private void Divide()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Divide), stack));
                return;
            }
            if(stack.Peek() == 0)
            {
                logger.LogError(Log.DivideByZero());
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second / first;
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Divide), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value modulo the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        ///  The result has the same sign as the divisor (the top value). If the top value is zero, this is a divide by zero error, which is handled as an implementation-dependent error, though simply ignoring the command is recommended. (See note below.)
        /// </remarks>
        private void Mod()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Mod), stack));
                return;
            }
            if (stack.Peek() < 1)
            {
                logger.LogError(Log.ModuloOnNotPositive(stack.Peek()));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second.Mod(first);
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Mod), first, second, result));
        }

        /// <summary>Replaces the top value of the stack with 0 if it is non-zero, and 1 if it is zero.</summary>
        private void Not()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Not), stack));
                return;
            }

            var value = stack.PopInt();
            var result = value == 0;
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Not), value));
        }

        /// <summary> Pops the top two values off the stack, and pushes 1 on to the stack if the second top value is greater than the top value, and pushes 0 if it is not greater.</summary>
        private void Greater()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Greater), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result =  second > first;
            stack.Push(result);

            logger.LogDebug(Log.Executed(nameof(Greater), first, second, result));
        }

        /// <summary>Pops the top value off the stack and rotates the DP clockwise that many steps (anticlockwise if negative).</summary>
        private void Pointer()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Pointer), stack));
                return;
            }

            var value = stack.PopInt();
            dp = dp.Rotate(value);

            logger.LogDebug(Log.Executed(nameof(Pointer), value));
        }

        /// <summary>Pops the top value off the stack and toggles the CC that many times (the absolute value of that many times if negative).</summary>
        private void Switch()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Switch), stack));
                return;
            }

            var value = stack.PopInt();
            cc = cc.Switch(value);

            logger.LogDebug(Log.Executed(nameof(Switch), value));
        }

        /// <summary> Pushes a copy of the top value on the stack on to the stack.</summary>
        private void Duplicate()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(Duplicate), stack));
                return;
            }

            var value = stack.Peek();
            stack.Push(value);
        }

        /// <summary>Pops the top two values off the stack and "rolls" the remaining stack entries to a depth equal to the second value popped, by a number of rolls equal to the first value popped.</summary>
        /// <remarks>
        /// A single roll to depth n is defined as burying the top value on the
        /// stack n deep and bringing all values above it up by 1 place. A negative
        /// number of rolls rolls in the opposite direction. A negative depth is an
        /// error and the command is ignored. If a roll is greater than an
        /// implementation-dependent maximum stack depth, it is handled as an
        /// implementation-dependent error, though simply ignoring the command
        /// is recommended.
        /// </remarks>
        private void Roll()
        {
            var first = stack.PopInt();
            var second = stack.PopInt();
            throw new NotImplementedException();
        }

        /// <summary>Reads a value from STDIN as either a number or character, depending on the particular incarnation of this command and pushes it on to the stack.</summary>
        /// <remarks>
        ///  If no input is waiting on STDIN, this is an error and the command
        ///  is ignored. If an integer read does not receive an integer value,
        ///  this is an error and the command is ignored.
        /// </remarks>
        private void InInt()
        {
            var input = io.InInt();

            if (!input.HasValue)
            {
                logger.LogError(Log.InvalidInput());
                return;
            }
            stack.Push(input.Value);

            logger.LogDebug(Log.Executed(nameof(InInt), input.Value));
        }

        /// <summary>Reads a value from STDIN as either a number or character, depending on the particular incarnation of this command and pushes it on to the stack.</summary>
        private void InChr()
        {
            var input = io.InChr();
            if (!input.HasValue)
            {
                logger.LogError(Log.InvalidInput());
                return;
            }
            stack.Push(input.Value);

            logger.LogDebug(Log.Executed(nameof(InChr), input.Value));
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        private void OutInt()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(OutInt), stack));
                return;
            }

            var value = stack.PopInt();
            io.Out(value);

            logger.LogDebug(Log.Executed(nameof(OutInt), value));
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        private void OutChr()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(Log.InsufficientStackSize(nameof(OutChr), stack));
                return;
            }

            var value = stack.PopChar();
            io.Out(value);

            logger.LogDebug(Log.Executed(nameof(OutChr), value));
        }

        private static readonly Dictionary<CodelDelta, Action<Interpreter>> commands = new Dictionary<CodelDelta, Action<Interpreter>>
        {
            { CodelDelta.None, /*     */ (i) => i.None() },
            { CodelDelta.Push, /*     */ (i) => i.Push() },
            { CodelDelta.Pop, /*      */ (i) => i.Pop() },
            { CodelDelta.Add, /*      */ (i) => i.Add() },
            { CodelDelta.Subtract, /* */ (i) => i.Subtract() },
            { CodelDelta.Multiply, /* */ (i) => i.Multiply() },
            { CodelDelta.Divide, /*   */ (i) => i.Divide() },
            { CodelDelta.Mod, /*      */ (i) => i.Mod() },
            { CodelDelta.Not, /*      */ (i) => i.Not() },
            { CodelDelta.Greater, /*  */ (i) => i.Greater() },
            { CodelDelta.Pointer, /*  */ (i) => i.Pointer() },
            { CodelDelta.Switch, /*   */ (i) => i.Switch() },
            { CodelDelta.Duplicate, /**/ (i) => i.Duplicate() },
            { CodelDelta.Roll, /*     */ (i) => i.Roll() },
            { CodelDelta.InInt, /*    */ (i) => i.InInt() },
            { CodelDelta.InChr, /*    */ (i) => i.InChr() },
            { CodelDelta.OutInt, /*   */ (i) => i.OutInt() },
            { CodelDelta.OutChr, /*   */ (i) => i.OutChr() },
        };
    }
}
