using Microsoft.Extensions.Logging;
using PietDotNet.IO;
using PietDotNet.Validation;
using System;
using System.Collections.Generic;

namespace PietDotNet
{
    public static class CommandExtensions
    {
        private delegate State Executable(State state, InOut io);

        public static State TryExecute(this Command cmd, State state, InOut io, ILogger logger)
        {
            try
            {
                var executed = cmd.Execute(state, io);
                logger.Command(executed, cmd);
                return executed;
            }
            catch (Terminated)
            {
                throw;
            }
            catch (Exception exception)
            {
                logger.Command(state, cmd, exception);
                return state;
            }
        }

        public static State Execute(this Command delta, State state, InOut io)
        {
            if (commands.TryGetValue(delta, out var command))
            {
                return command(state, io);
            }
            else throw new NotSupportedDelta();
        }

        internal static State None(State state, InOut io) => state;

        /// <summary>Pushes the value of the colour block just exited on to the stack.</summary>
        /// <remarks>
        ///  Note that values of colour blocks are not automatically pushed on to the stack - this push operation must be explicitly carried out.
        /// </remarks>
        internal static State Push(State state, InOut io)
        {
            return state.With(state.Stack.Push(state.Value));
        }

        /// <summary>Pops the top value off the stack and discards it.</summary>
        internal static State Pop(State state, InOut io)
        {
            return state.With(state.Stack.Pop());
        }

        /// <summary>Pops the top two values off the stack, adds them, and pushes the result back on the stack.</summary>
        internal static State Add(State state, InOut io)
        {
            return state.With(state.Stack.Add());
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value minus the top value, and pushes the result back on the stack.</summary>
        internal static State Subtract(State state, InOut io)
        {
            return state.With(state.Stack.Subtract());
        }

        /// <summary>Pops the top two values off the stack, multiplies them, and pushes the result back on the stack.</summary>
        internal static State Multiply(State state, InOut io)
        {
            return state.With(state.Stack.Multiply());
        }

        /// <summary>Pops the top two values off the stack, calculates the integer division of the second top value by the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        /// If a divide by zero occurs, it is handled as an implementation-dependent error, though simply ignoring the command is recommended.
        /// </remarks>
        internal static State Divide(State state, InOut io)
        {
            return state.With(state.Stack.Divide());
        }

        /// <summary>Pops the top two values off the stack, calculates the second top value modulo the top value, and pushes the result back on the stack.</summary>
        /// <remarks>
        ///  The result has the same sign as the divisor (the top value). If the top value is zero, this is a divide by zero error, which is handled as an implementation-dependent error, though simply ignoring the command is recommended. (See note below.)
        /// </remarks>
        internal static State Modulo(State state, InOut io)
        {
            return state.With(state.Stack.Modulo());
        }

        /// <summary>Replaces the top value of the stack with 0 if it is non-zero, and 1 if it is zero.</summary>
        internal static State Not(State state, InOut io)
        {
            return state.With(state.Stack.Not());
        }

        /// <summary> Pops the top two values off the stack, and pushes 1 on to the stack if the second top value is greater than the top value, and pushes 0 if it is not greater.</summary>
        internal static State Greater(State state, InOut io)
        {
            return state.With(state.Stack.Greater());
        }

        /// <summary>Pops the top value off the stack and rotates the DP clockwise that many steps (anticlockwise if negative).</summary>
        internal static State Rotate(State state, InOut io)
        {
            return state.With
            (
                state.Pointer.Rotate(state.Stack.First()),
                state.Stack.Pop()
            );
        }

        /// <summary>Pops the top value off the stack and toggles the CC that many times (the absolute value of that many times if negative).</summary>
        internal static State Switch(State state, InOut io)
        {
            return state.With
            (
                state.Pointer.Switch(state.Stack.First()),
                state.Stack.Pop()
            );
        }

        /// <summary> Pushes a copy of the top value on the stack on to the stack.</summary>
        internal static State Duplicate(State state, InOut io)
        {
            return state.With(state.Stack.Duplicate());
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
        internal static State Roll(State state, InOut io)
        {
            return state.With(state.Stack.Roll());
        }

        /// <summary>Reads a value from STDIN as either a number or character, depending on the particular incarnation of this command and pushes it on to the stack.</summary>
        /// <remarks>
        ///  If no input is waiting on STDIN, this is an error and the command
        ///  is ignored. If an integer read does not receive an integer value,
        ///  this is an error and the command is ignored.
        /// </remarks>
        internal static State InInt(State state, InOut io)
        {
            var input = io.InInt().HasInput();
            return state.With(state.Stack.Push(input));
        }

        /// <summary>Reads a value from STDIN as either a number or character, depending on the particular incarnation of this command and pushes it on to the stack.</summary>
        internal static State InChr(State state, InOut io)
        {
            var input = io.InChr().HasInput();
            return state.With(state.Stack.Push(input));
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        internal static State OutInt(State state, InOut io)
        {
            var value = state.Stack.Peek();
            io.Out(value);
            return state.With(state.Stack.Pop());
        }

        /// <summary>Pops the top value off the stack and prints it to STDOUT as either a number or character, depending on the particular incarnation of this command.</summary>
        internal static State OutChr(State state, InOut io)
        {
            var value = (char)state.Stack.Peek();
            io.Out(value);
            return state.With(state.Stack.Pop());
        }

        private static readonly Dictionary<Command, Executable> commands = new Dictionary<Command, Executable>
        {
            { Command.None, /*     */ None },
            { Command.Push, /*     */ Push },
            { Command.Pop, /*      */ Pop },
            { Command.Add, /*      */ Add },
            { Command.Subtract, /* */ Subtract },
            { Command.Multiply, /* */ Multiply },
            { Command.Divide, /*   */ Divide },
            { Command.Modulo, /*   */ Modulo },
            { Command.Not, /*      */ Not },
            { Command.Greater, /*  */ Greater },
            { Command.Rotate, /*   */ Rotate },
            { Command.Switch, /*   */ Switch },
            { Command.Duplicate, /**/ Duplicate },
            { Command.Roll, /*     */ Roll },
            { Command.InInt, /*    */ InInt },
            { Command.InChr, /*    */ InChr },
            { Command.OutInt, /*   */ OutInt },
            { Command.OutChr, /*   */ OutChr },
        };
    }
}
