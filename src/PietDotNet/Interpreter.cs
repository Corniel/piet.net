using PietDotNet.IO;
using PietDotNet.Logging;
using PietDotNet.Validation;
using System;
using System.Collections.Generic;

namespace PietDotNet
{
    public static class Interpreter
    {
        public static void Run(this Program program, InOut io, Logger logger, long maxRuns = long.MaxValue)
        {
            long runs = 0;
            var state = State.Initial(program);
            logger.Start(state);

            try
            {
                while (runs++ < maxRuns)
                {
                    state = Traverse(state, program, logger);
                    var current = program.SelectBlock(state);
                    var cmd = current.Colour - state.Colour;
                    state = cmd.TryExecute(state, io, logger);
                    state = state.SelectBlock(current);
                }
            }
            catch (Terminated)
            {
                logger.Terminated(state, runs);
            }
        }

        private static State Traverse(State state, Program program, Logger logger)
        {
            var traversed = state.PointerLeaves(program.SelectBlock(state));
            var target = program.SelectBlock(traversed);

            if (target.IsBlack) return TraverseBlack(state, program, logger);
            else if (target.IsWhite) return TraverseWhite(traversed, program, logger);
            else return traversed;
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
        internal static State TraverseBlack(State state, Program program, Logger logger, int retry = 0)
        {
            if (retry >= 8) throw new Terminated();

            var traversed = retry.IsEven()
                ? state.Switch()
                : state.Rotate();

            var leave = traversed.PointerLeaves(program.SelectBlock(traversed));
            var block = program.SelectBlock(leave);

            if (block.IsBlack) return TraverseBlack(traversed, program, logger, retry + 1);
            else if (block.IsWhite) return TraverseWhite(leave, program, logger);
            else return leave;
        }

        /// <summary>Handles traverse for white codels.</summary>
        /// <remarks>
        /// Sliding across white blocks takes the interpreter in a straight
        /// line until it hits a coloured pixel or edge.
        /// 
        /// 1. The interpreter "slides" across the white block in a straight line.
        /// 2. If it hits a restriction, the CC is toggled.Since this results
        ///    in no difference in where the interpreter is trying to go, the
        ///    DP is immediately stepped clockwise.
        /// 3. The interpreter now begins sliding from its current white codel,
        ///    in the new direction of the DP, until it either enters a
        ///    coloured block or encounters another restriction.
        /// 4. Each time the interpreter hits a restriction while within the
        ///    white block, it toggles the CC and steps the DP clockwise, then
        ///    tries to slide again. This process repeats until the interpreter
        ///    either enters a coloured block (where execution then continues);
        ///    or until the interpreter begins retracing its route.If it retraces
        ///    its route entirely within a white block, there is no way out of
        ///    the white block and execution should terminate.
        /// </remarks>
        private static State TraverseWhite(State state, Program program, Logger logger)
        {
            var visits = new HashSet<Pointer>();

            var traversed = state;

            // if the step was already added, we're retracing the route. 
            while (visits.Add(traversed.Pointer))
            {
                var next_state = traversed.SingleStep();
                var next_block = program.SelectBlock(next_state);

                if (next_block.HasColour)
                {
                    traversed = next_state.SelectBlock(next_block);
                    return Traverse(traversed, program, logger);
                }
                else if (next_block.IsWhite)
                {
                    traversed = next_state;
                }
                else
                {
                    traversed = traversed.Switch().Rotate();
                }
            }
            throw new Terminated();
        }
    }
}
