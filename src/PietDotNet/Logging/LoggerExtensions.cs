using System;

namespace PietDotNet.Logging
{
    internal static class LoggerExtensions
    {
        public static void Start(this Logger logger, State state)
        {
            logger.LogInfo($"{state.Debug()} START()");
        }

        public static void Terminated(this Logger logger, State state, long commands)
        {
            logger.LogInfo($"{state.Debug()} EXIT() // Terminated after {commands:#,##0} commands.");
        }

        public static void Command(this Logger logger, State state, Command cmd)
        {
            var name = cmd.Name.ToUpperInvariant().Substring(0, 3);

            logger.LogInfo($"{state.Debug()} {name}() // [{string.Join(", ", state.Stack)}]");
        }

        public static void Command(this Logger logger, State state, Command cmd, Exception exception)
        {
            var name = cmd.Name.ToUpperInvariant().Substring(0, 3);
            logger.LogError($"{state.Position} {name}() ERROR: {exception.Message}");
        }

        private static void LogError(this Logger logger, string message) => logger.Log(LogLevel.Error, message);
        private static void LogInfo(this Logger logger, string message) => logger.Log(LogLevel.Info, message);

        private static string Debug(this State state)
        {
            var c = state.Pointer;
            var dir = $"{c.DP.ToString()[0]}{c.CC.ToString()[0]}".ToUpperInvariant();
            return $"{state.Position} {state.Colour.Debug()} {dir}";
        }
    }
}
