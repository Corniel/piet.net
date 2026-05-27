using Piet.Syntax;

namespace Piet.Interpreting.Logging;

internal static class LoggerExtensions
{
    extension(Logger logger)
    {
        public void Start(Context ctx)
        {
            if (logger.MinLevel >= LogLevel.Info)
                logger.LogInfo($"{ctx.Debug()} START()");
        }

        public void Terminated(Context ctx, long commands)
        {
            if (logger.MinLevel >= LogLevel.Info)
                logger.LogInfo($"{ctx.Debug()} EXIT() // Terminated after {commands:#,##0} commands.");
        }

        public void Command(Context ctx, Command cmd)
        {
            if (logger.MinLevel >= LogLevel.Info)
                logger.LogInfo($"{ctx.Debug()} {cmd}() // [{string.Join(", ", ctx.State.Stack)}]");
        }

        private void LogInfo(string message) => logger.Log(LogLevel.Info, message);
    }

    private static string Debug(this Context ctx)
        => $"{ctx.Block.Edges[ctx.State.PT]} {ctx.Block.Colour.Debug()} {ctx.State.PT}";
}
