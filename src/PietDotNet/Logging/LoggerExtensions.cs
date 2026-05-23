namespace PietDotNet.Logging;

internal static class LoggerExtensions
{
    extension(Logger logger)
    {
        public void Start(State state)
        {
            if (logger.MinLevel >= LogLevel.Info)
                logger.LogInfo($"{state.Debug()} START()");
        }

        public void Terminated(State state, long commands)
        {
            if (logger.MinLevel >= LogLevel.Info)
                logger.LogInfo($"{state.Debug()} EXIT() // Terminated after {commands:#,##0} commands.");
        }

        public void Command(State state, Command cmd)
        {
            if (logger.MinLevel >= LogLevel.Info)
                logger.LogInfo($"{state.Debug()} {cmd}() // [{string.Join(", ", state.Stack)}]");
        }

        public void Command(State state, Command cmd, Exception exception)
        {
            if (logger.MinLevel >= LogLevel.Error)
                logger.LogError($"{state.Position} {cmd}() ERROR: {exception.Message}");
        }

        private void LogError(string message) => logger.Log(LogLevel.Error, message);

        private void LogInfo(string message) => logger.Log(LogLevel.Info, message);
    }

    private static string Debug(this State state)
    {
        var c = state.Pointer;
        var dir = $"{c.DP.ToString()[0]}{c.CC.ToString()[0]}".ToUpperInvariant();
        return $"{state.Position} {state.Colour.Debug()} {dir}";
    }
}
