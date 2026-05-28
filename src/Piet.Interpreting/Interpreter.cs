using Piet.Interpreting.Logging;
using Piet.Syntax;

namespace Piet.Interpreting;

public static class Interpreter
{
    extension(Program program)
    {
        public Context Watch() => program.Run(Context.Default());

        public Context Run(Context context)
        {
            context.Block = program[Codel.EntryPoint];

            long runs = 0;
            var run = true;

            context.Logger.Start(context);

            while (run && context.Block.HasColour && runs++ < context.MaxRuns)
            {
                run = Next(ref context);
            }
            context.Logger.Terminated(context, runs);

            return context;
        }

        private static bool Next(ref Context context)
        {
            var state = context.State;
            var curr = context.Block;
            var next = context.Block.Neighbours[state.PT];

            // Process white blocks
            while (next.Reset)
            {
                curr = next.Block;
                next = curr.Neighbours[next.PT];
            }

            state.PT = next.PT;

            if (!next.Block.HasColour) return false;

            var cmd = next.Block.Colour - curr.Colour;

            context.Block = next.Block;
            context.State = cmd.Execute(state, curr.Value);
            context.Logger.Command(context, cmd);

            return true;
        }
    }
}
