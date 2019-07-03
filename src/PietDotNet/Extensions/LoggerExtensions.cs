using PietDotNet;
using System.Drawing;
using System.Linq;

namespace Microsoft.Extensions.Logging
{
    public static class LoggerExtensions
    {
        public static void TraceLocation(this ILogger logger, State state)
        {
            logger.LogTrace($"{state.Active.Debug()} MOV()");
        }

        public static void InfoCommand(this ILogger logger, State state, object @return, params object[] args)
        {
            var cmd = state.Delta.Action.ToUpperInvariant().Substring(0, 3);
            var arguments = string.Join(", ", args.Select(arg => arg.DebugValue()));
            var ret = @return is null ? "" : $" => {@return.DebugValue()}";

            logger.LogInformation($"{state.Active.Debug()} {cmd}({arguments}){ret}");
        }

        public static void ErrorInsufficientStackSize(this ILogger logger, State state, int items)
        {
            var cmd = state.Delta.Action.ToUpperInvariant().Substring(0, 3);
            var arguments = string.Join(", ", new string('?', items));

            logger.LogError($"{state.Active.Debug()} {cmd}({arguments}) // Insufficient stack size ({state.Stack.Count}).");
        }

        public static void ErrorDivideByZero(this ILogger logger, State state, long numerator, long denumerator)
        {
            logger.LogError($"{state.Active.Debug()} DIV({numerator.DebugValue()}, {denumerator.DebugValue()}) // Can not divide by zero.");
        }

        public static void ErrorModulo(this ILogger logger, State state, long value, long modulo)
        {
            logger.LogError($"{state.Active.Debug()} MOD({value.DebugValue()}, {modulo.DebugValue()}) // Can not perform modulo on a not positive value.");
        }

        public static void ErrorRollDepth(this ILogger logger, State state, long roll, long depth)
        {
            logger.LogError($"{state.Active.Debug()} ROL({roll.DebugValue()}, {depth.DebugValue()}) // The roll depth is invalid.");
        }

        public static void ErrorInput(this ILogger logger, State state)
        {
            logger.LogError($"{state.Active.Debug()} INP() // Invalid input.");
        }

        public static void Terminated(this ILogger logger, State state, long commands)
        {
            logger.LogWarning($"{state.Active.Debug()} EXIT // Terminated after {commands:#,##0} commands.");
        }

        public static string DebugValue(this object obj)
        {
            if(obj is char ch)
            {
                return $"'{ch}'";
            }
            if(obj is long n)
            {
                return n.ToString("#,##0");
            }
            return obj?.ToString();
        }
    }
}
