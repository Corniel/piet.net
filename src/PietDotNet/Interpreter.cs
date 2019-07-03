using Microsoft.Extensions.Logging;
using PietDotNet.Logging;
using System;
using System.Collections.Generic;

namespace PietDotNet
{
    public class Interpreter
    {
        public Interpreter(Program program, IInOut io = null, ILogger logger = null, long maxCommands = long.MaxValue)
        {
            this.io = io ?? new ConsoleInOut();
            this.logger = logger ?? new ConsoleLogger();
            state = new State(program, new Stack());
            MaxCommands = maxCommands;
        }

        private readonly IInOut io;
        private readonly ILogger logger;

        private readonly State state;
        private Stack stack => state.Stack;
        private bool executing = true;
        public long Commands { get; private set; }

        public long MaxCommands { get; }

        /// <summary>Executes the <see cref="Program"/>.</summary>
        public void Run()
        {
            while (executing)
            {
                Traverse();
                Execute();
            }
            logger.Terminated(state, Commands);
        }

        /// <summary>Traveres the pointer to the next codel.</summary>
        /// The interpreter finds the edge of the current colour block which is
        /// furthest in the direction of the DP. (This edge may be disjoint if
        /// the block is of a complex shape.)
        /// </remarks>
        private void Traverse()
        {
            while (state.OnColourBlock)
            {
                state.MoveForward();
                logger.TraceLocation(state);
            }
            if(state.IsWhite)
            {
                executing = OnWhite();
            }
            else if (state.IsBlack)
            {
                executing = OnBlack();
            }
            else
            {
                state.UpdateCurrent();

                while (state.OnColourBlock)
                {
                    state.UpdateCurrent();
                    state.MoveAside();
                    logger.TraceLocation(state);
                }

                state.ResetActive();
            }
        }

        /// <summary>Handles traverse for black codels (and program edges).</summary>
        /// <remarks>
        /// Black colour blocks and the edges of the program restrict program
        /// flow. If the Piet interpreter attempts to move into a black block
        /// or off an edge, it is stopped and the CC is toggled. The interpreter
        /// then attempts to move from its current block again. If it fails a
        /// second time, the DP is moved clockwise one step. These attempts are
        /// repeated, with the CC and DP being changed between alternate attempts.
        /// If after eight attempts the interpreter cannot leave its current
        /// colour block, there is no way out and the program terminates. 
        /// </remarks>
        private bool OnBlack(int retryCount = 8)
        {
            // Active is on forbidden ground.
            state.ResetActive();

            while (retryCount > 0)
            {
                // Switch on 0th, 2nd, 4th and 6th attempt.
                if ((retryCount & 1) == 0)
                {
                    state.SwitchCC();
                }
                else
                {
                    state.RotateDP();
                }
                retryCount--;

                while (state.OnColourBlock)
                {
                    state.MoveAside();
                    logger.TraceLocation(state);
                }
                if (state.IsBlack)
                {
                    return OnBlack(retryCount);
                }
                if(state.IsWhite)
                {
                    throw new NotImplementedException("TODO deal with White.");
                }
                state.UpdateCurrent();
                return true;
            }

            logger.Terminated(state, 0);
            return false;
        }

        private bool OnWhite(int retryCount = 8)
        {
            throw new NotImplementedException();
        }

        /// <summary>Executes a command based on the delta of the last two codels.</summary>
        private void Execute()
        {
            if (commands.TryGetValue(state.Delta, out var command))
            {
                command.Invoke(this);
                state.UpdatePrevious();

                if (++Commands >= MaxCommands)
                {
                    executing = false;
                }
            }
            else
            {
                throw new InvalidOperationException($"Could not execute delta {state.Delta}.");
            }
        }

        private void None() { /*Do nothing */ }

        /// <summary>Pushes the value of the colour block just exited on to the stack.</summary>
        /// <remarks>
        ///  Note that values of colour blocks are not automatically pushed on to the stack - this push operation must be explicitly carried out.
        /// </remarks>
        private void Push()
        {
            stack.Push(state.Value);
            logger.InfoCommand(state, null, state.Value);
        }

        /// <summary>Pops the top value off the stack and discards it.</summary>
        private void Pop()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.PopInt();

            logger.InfoCommand(state, value);
        }

        /// <summary>Pops the top two values off the stack, adds them, and pushes the result back on the stack.</summary>
        private void Add()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second + first;
            stack.Push(result);

            logger.InfoCommand(state, result, first, second);
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value minus the top value, and pushes the result back on the stack.</summary>
        private void Subtract()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second - first;
            stack.Push(result);

            logger.InfoCommand(state, result, first, second);
        }

        /// <summary>Pops the top two values off the stack, multiplies them, and pushes the result back on the stack.</summary>
        private void Multiply()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second * first;
            stack.Push(result);

            logger.InfoCommand(state, result, first, second);
        }

        /// <summary>Pops the top two values off the stack, calculates the integer division of the second top value by the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        /// If a divide by zero occurs, it is handled as an implementation-dependent error, though simply ignoring the command is recommended.
        /// </remarks>
        private void Divide()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }
            if (stack.Peek() == 0)
            {
                logger.ErrorDivideByZero(state, stack[0], stack[1]);
                return;
            }

            var numerator = stack.PopInt();
            var denumerator = stack.PopInt();

            var result = denumerator / numerator;
            stack.Push(result);

            logger.InfoCommand(state, result, numerator, denumerator);
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value modulo the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        ///  The result has the same sign as the divisor (the top value). If the top value is zero, this is a divide by zero error, which is handled as an implementation-dependent error, though simply ignoring the command is recommended. (See note below.)
        /// </remarks>
        private void Mod()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }
            if (stack.Peek() < 1)
            {
                logger.ErrorModulo(state, stack[0], stack[1]);
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second.Mod(first);
            stack.Push(result);

            logger.InfoCommand(state, result, first, second);
        }

        /// <summary>Replaces the top value of the stack with 0 if it is non-zero, and 1 if it is zero.</summary>
        private void Not()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.PopInt();
            var result = value == 0;
            stack.Push(result);

            logger.InfoCommand(state, result, value);
        }

        /// <summary> Pops the top two values off the stack, and pushes 1 on to the stack if the second top value is greater than the top value, and pushes 0 if it is not greater.</summary>
        private void Greater()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }

            var first = stack.PopInt();
            var second = stack.PopInt();

            var result = second > first;
            stack.Push(result);

            logger.InfoCommand(state, result, first, second);
        }

        /// <summary>Pops the top value off the stack and rotates the DP clockwise that many steps (anticlockwise if negative).</summary>
        private void Pointer()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.PopInt();
            state.RotateDP(value);

            logger.InfoCommand(state, null, value);
        }

        /// <summary>Pops the top value off the stack and toggles the CC that many times (the absolute value of that many times if negative).</summary>
        private void Switch()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.PopInt();
            state.SwitchCC(value);

            logger.InfoCommand(state, null, value);
        }

        /// <summary> Pushes a copy of the top value on the stack on to the stack.</summary>
        private void Duplicate()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.Peek();
            stack.Push(value);

            logger.InfoCommand(state, null, value);
        }

        /// <summary>Pops the top two values off the stack and "rolls" the remaining stack entries to a depth equal to the second value popped, by a number of rolls equal to the first value popped.</summary>
        /// <remarks>
        /// A single roll to depth n is defined as burying the top value on the
        /// stack n deep and bringing all values above it up by 1 place. A negative
        /// number of rolls, rolls in the opposite direction. A negative depth is an
        /// error and the command is ignored. If a roll is greater than an
        /// implementation-dependent maximum stack depth, it is handled as an
        /// implementation-dependent error, though simply ignoring the command
        /// is recommended.
        /// </remarks>
        private void Roll()
        {
            if (!stack.HasMultiple())
            {
                logger.ErrorInsufficientStackSize(state, 2);
                return;
            }
            if (stack[1] < 0 || stack[1] > stack.Count - 2)
            {
                logger.ErrorRollDepth(state, stack[0], stack[1]);
                return;
            }

            var roll = stack.PopInt();
            var depth = stack.PopInt();
            stack.Roll((int)roll, (int)depth);

            logger.InfoCommand(state, null, roll, depth);
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
                logger.ErrorInput(state);
                return;
            }
            stack.Push(input.Value);

            logger.InfoCommand(state, null, input.Value);
        }

        /// <summary>Reads a value from STDIN as either a number or character, depending on the particular incarnation of this command and pushes it on to the stack.</summary>
        private void InChr()
        {
            var input = io.InChr();
            if (!input.HasValue)
            {
                logger.ErrorInput(state);
                return;
            }
            stack.Push(input.Value);

            logger.InfoCommand(state, null, input.Value);
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        private void OutInt()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.PopInt();
            io.Out(value);

            logger.InfoCommand(state, value);
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        private void OutChr()
        {
            if (!stack.HasAny())
            {
                logger.ErrorInsufficientStackSize(state, 1);
                return;
            }

            var value = stack.PopChar();
            io.Out(value);

            logger.InfoCommand(state, value);
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

        /// <inheritdoc />
        public override string ToString() => state.ToString();
    }
}
