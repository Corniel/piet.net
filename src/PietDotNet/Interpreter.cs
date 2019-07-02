using Microsoft.Extensions.Logging;
using PietDotNet.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace PietDotNet
{
    [DebuggerDisplay("{DebuggerDisplay}")]
    public class Interpreter
    {
        private readonly Program program;
        private readonly IInOut io;
        private readonly ILogger logger;

        private readonly Stack stack = new Stack();

        private CodelChooser cc;
        private DirectionPointer dp;
        internal Point prevPoint;
        internal Point currPoint;
        private Codel prev;
        internal Codel curr;
        private bool executing = true;
        
        public Interpreter(Program program, IInOut io = null, ILogger logger = null)
        {
            this.program = Guard.NotNull(program, nameof(program));
            this.io = io ?? new ConsoleInOut();
            this.logger = logger ?? new ConsoleLogger();

            LogHelper = new InterpreterLogHelper(this);
        }

        private InterpreterLogHelper LogHelper { get; }

        public void Execute()
        {
            prev = program[currPoint];

            // start with identical values.
            curr = prev;

            while (executing)
            {
                var delta = Traverse();
                Execute(delta);
            }
        }

        /// <summary>Traveres the pointer to the next codel.</summary>
        /// The interpreter finds the edge of the current colour block which is
        /// furthest in the direction of the DP. (This edge may be disjoint if
        /// the block is of a complex shape.)
        /// </remarks>
        private Delta Traverse()
        {
            // The interpreter finds the edge of the current colour block which is furthest in the direction of the DP. (This edge may be disjoint if the block is of a complex shape.)
            var terminationCounter = 0;

            while (terminationCounter < 8)
            {
                var pt = currPoint.Next(dp);
                curr = program[pt];

                logger.LogDebug($"{pt} codel {curr}");

                if (curr.IsBlack)
                {
                    // rotate ect.
                    if ((terminationCounter & 1) == 0)
                    {
                        dp = dp.Rotate(1);
                    }
                    else
                    {
                        cc = cc.Switch(1);
                    }
                    logger.LogDebug($"DP {dp} CC {cc}");

                    curr = prev;
                    terminationCounter++;
                }
                else
                {
                    prevPoint = currPoint;
                    currPoint = pt;

                    if (!curr.IsWhite && !prev.IsWhite)
                    {
                        var delta = curr - prev;
                        if (delta != Delta.None)
                        {
                            prev = curr;
                            return delta;
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
            logger.LogDebug("Program terminates");
            executing = false;
            return Delta.None;
        }

        private void Execute(Delta delta)
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
            var value = program.Value(prevPoint);
            stack.Push(value);

            logger.LogDebug(LogHelper.Executed(nameof(Push), value));
        }

        /// <summary>Pops the top value off the stack and discards it.</summary>
        private void Pop()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Pop), stack));
                return;
            }

            var value = stack.PopInt();

            logger.LogDebug(LogHelper.Executed(nameof(Pop), value));
        }

        /// <summary>Pops the top two values off the stack, adds them, and pushes the result back on the stack.</summary>
        private void Add()
        {
            if(!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Add), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second + first;
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Add), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value minus the top value, and pushes the result back on the stack.</summary>
        private void Subtract()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Subtract), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second - first;
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Subtract), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, multiplies them, and pushes the result back on the stack.</summary>
        private void Multiply()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Multiply), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second * first;
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Multiply), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, calculates the integer division of the second top value by the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        /// If a divide by zero occurs, it is handled as an implementation-dependent error, though simply ignoring the command is recommended.
        /// </remarks>
        private void Divide()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Divide), stack));
                return;
            }
            if(stack.Peek() == 0)
            {
                logger.LogError(LogHelper.DivideByZero());
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second / first;
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Divide), first, second, result));
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value modulo the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        ///  The result has the same sign as the divisor (the top value). If the top value is zero, this is a divide by zero error, which is handled as an implementation-dependent error, though simply ignoring the command is recommended. (See note below.)
        /// </remarks>
        private void Mod()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Mod), stack));
                return;
            }
            if (stack.Peek() < 1)
            {
                logger.LogError(LogHelper.ModuloOnNotPositive(stack.Peek()));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second.Mod(first);
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Mod), first, second, result));
        }

        /// <summary>Replaces the top value of the stack with 0 if it is non-zero, and 1 if it is zero.</summary>
        private void Not()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Not), stack));
                return;
            }

            var value = stack.PopInt();
            var result = value == 0;
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Not), value));
        }

        /// <summary> Pops the top two values off the stack, and pushes 1 on to the stack if the second top value is greater than the top value, and pushes 0 if it is not greater.</summary>
        private void Greater()
        {
            if (!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Greater), stack));
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result =  second > first;
            stack.Push(result);

            logger.LogDebug(LogHelper.Executed(nameof(Greater), first, second, result));
        }

        /// <summary>Pops the top value off the stack and rotates the DP clockwise that many steps (anticlockwise if negative).</summary>
        private void Pointer()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Pointer), stack));
                return;
            }

            var value = stack.PopInt();
            dp = dp.Rotate(value);

            logger.LogDebug(LogHelper.Executed(nameof(Pointer), value));
        }

        /// <summary>Pops the top value off the stack and toggles the CC that many times (the absolute value of that many times if negative).</summary>
        private void Switch()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Switch), stack));
                return;
            }

            var value = stack.PopInt();
            cc = cc.Switch(value);

            logger.LogDebug(LogHelper.Executed(nameof(Switch), value));
        }

        /// <summary> Pushes a copy of the top value on the stack on to the stack.</summary>
        private void Duplicate()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Duplicate), stack));
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
            if (!stack.HasMultiple())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(Roll), stack));
                return;
            }
            if(stack[1] < 0 || stack[1] > stack.Count -2)
            {
                logger.LogError(LogHelper.InvalidRollDepth(stack[1]));
                return;
            }

            var roll = stack.PopInt();
            var depth = stack.PopInt();
            stack.Roll((int)roll, (int)depth);
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
                logger.LogError(LogHelper.InvalidInput());
                return;
            }
            stack.Push(input.Value);

            logger.LogDebug(LogHelper.Executed(nameof(InInt), input.Value));
        }

        /// <summary>Reads a value from STDIN as either a number or character, depending on the particular incarnation of this command and pushes it on to the stack.</summary>
        private void InChr()
        {
            var input = io.InChr();
            if (!input.HasValue)
            {
                logger.LogError(LogHelper.InvalidInput());
                return;
            }
            stack.Push(input.Value);

            logger.LogDebug(LogHelper.Executed(nameof(InChr), input.Value));
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        private void OutInt()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(OutInt), stack));
                return;
            }

            var value = stack.PopInt();
            io.Out(value);

            logger.LogDebug(LogHelper.Executed(nameof(OutInt), value));
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        private void OutChr()
        {
            if (!stack.HasAny())
            {
                logger.LogWarning(LogHelper.InsufficientStackSize(nameof(OutChr), stack));
                return;
            }

            var value = stack.PopChar();
            io.Out(value);

            logger.LogDebug(LogHelper.Executed(nameof(OutChr), value));
        }

        private static readonly Dictionary<Delta, Action<Interpreter>> commands = new Dictionary<Delta, Action<Interpreter>>
        {
            { Delta.None, /*     */ (i) => i.None() },
            { Delta.Push, /*     */ (i) => i.Push() },
            { Delta.Pop, /*      */ (i) => i.Pop() },
            { Delta.Add, /*      */ (i) => i.Add() },
            { Delta.Subtract, /* */ (i) => i.Subtract() },
            { Delta.Multiply, /* */ (i) => i.Multiply() },
            { Delta.Divide, /*   */ (i) => i.Divide() },
            { Delta.Mod, /*      */ (i) => i.Mod() },
            { Delta.Not, /*      */ (i) => i.Not() },
            { Delta.Greater, /*  */ (i) => i.Greater() },
            { Delta.Pointer, /*  */ (i) => i.Pointer() },
            { Delta.Switch, /*   */ (i) => i.Switch() },
            { Delta.Duplicate, /**/ (i) => i.Duplicate() },
            { Delta.Roll, /*     */ (i) => i.Roll() },
            { Delta.InInt, /*    */ (i) => i.InInt() },
            { Delta.InChr, /*    */ (i) => i.InChr() },
            { Delta.OutInt, /*   */ (i) => i.OutInt() },
            { Delta.OutChr, /*   */ (i) => i.OutChr() },
        };

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string DebuggerDisplay
        {
            get
            {
                var sb = new StringBuilder()
                    .Append($"Curr: {curr.RgbCode} ({currPoint.X,2}, {currPoint.Y,2}), ")
                    .Append($"Prev: {prev.RgbCode} ({prevPoint.X,2}, {prevPoint.Y,2})")
                ;
                if (!curr.IsBlackOrWhite && !prev.IsBlackOrWhite)
                {
                    var delta = curr - prev;
                    var value = program.Value(currPoint);

                    var str = delta == Delta.OutChr
                        ? "'" + ((char)value).ToString() + "'"
                        : value.ToString();

                    sb.Append($", Action: {delta.Action}, Value: {str}");
                }
                return sb.ToString();
            }
        }
    }
}
