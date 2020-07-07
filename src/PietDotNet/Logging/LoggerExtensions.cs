using PietDotNet;
using System;
using System.Drawing;

namespace Microsoft.Extensions.Logging
{
    internal static class LoggerExtensions
    {
        public static void Start(this ILogger logger, State state)
        {
            logger.LogInformation($"{state.Debug()} START()");
        }

        public static void Terminated(this ILogger logger, State state, long commands)
        {
            logger.LogInformation($"{state.Debug()} EXIT() // Terminated after {commands:#,##0} commands.");
        }

        public static void Command(this ILogger logger, State state, Command cmd)
        {
            var name = cmd.Name.ToUpperInvariant().Substring(0, 3);

            logger.LogInformation($"{state.Debug()} {name}() // [{string.Join(", ", state.Stack)}]");
        }

        public static void Command(this ILogger logger, State state, Command cmd, Exception exception)
        {
            var name = cmd.Name.ToUpperInvariant().Substring(0, 3);
            logger.LogError($"{state.Position.Debug()} {name}() ERROR: {exception.Message}");
        }

        private static string Debug(this State state)
        {
            var c = state.Pointer;
            var dir = $"{c.DP.ToString()[0]}{c.CC.ToString()[0]}".ToUpperInvariant();
            return $"{state.Position.Debug()} {state.Codel.Colour.Debug()} {dir}";
        }
    }
}
