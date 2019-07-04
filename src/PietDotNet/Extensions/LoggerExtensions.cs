using PietDotNet;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Microsoft.Extensions.Logging
{
    public static class LoggerExtensions
    {
        public static void TraceLocation(this ILogger logger, State state)
        {
            if (!state.Program.OnCanvas(state.Pointer))
            {
                logger.LogWarning($"{state.Pointer.Debug()} MOV() // Not on canvas.");
            }
            else if (state.Program[state.Pointer].IsBlack)
            {
                logger.LogWarning($"{state.Pointer.Debug()} MOV() // black codel.");
            }
            else
            {
                logger.LogTrace($"{state.Pointer.Debug()} MOV() // {state.Program[state.Pointer].Colour.Debug()} codel.");
            }
        }

        public static void TraceSwitchCC(this ILogger logger, State state, int retryCount)
        {
            logger.LogTrace($"{state.Pointer.Debug()} SWI() // Switched the CC to {state.CC}, {retryCount} attempts to go.");
        }

        public static void TraceRotateDP(this ILogger logger, State state, int retryCount)
        {
            logger.LogTrace($"{state.Pointer.Debug()} ROT() // Switched the DP to {state.DP}, {retryCount} attempts to go.");
        }


        public static void InfoCommand(this ILogger logger, State state, object @return, params object[] args)
        {
            var cmd = state.Delta.Action.ToUpperInvariant().Substring(0, 3);
            var arguments = string.Join(", ", args.Select(arg => arg.DebugValue()));
            var ret = @return is null ? "" : $" => {@return.DebugValue()}";

            logger.LogInformation($"{state.Pointer.Debug()} {cmd}({arguments}){ret}");
        }

        public static void ErrorInsufficientStackSize(this ILogger logger, State state, int items)
        {
            var cmd = state.Delta.Action.ToUpperInvariant().Substring(0, 3);
            var arguments = string.Join(", ", new string('?', items));

            logger.LogError($"{state.Pointer.Debug()} {cmd}({arguments}) // Insufficient stack size ({state.Stack.Count}).");
        }

        public static void ErrorDivideByZero(this ILogger logger, State state, long numerator, long denumerator)
        {
            logger.LogError($"{state.Pointer.Debug()} DIV({numerator.DebugValue()}, {denumerator.DebugValue()}) // Can not divide by zero.");
        }

        public static void ErrorModulo(this ILogger logger, State state, long value, long modulo)
        {
            logger.LogError($"{state.Pointer.Debug()} MOD({value.DebugValue()}, {modulo.DebugValue()}) // Can not perform modulo on a not positive value.");
        }

        public static void ErrorRollDepth(this ILogger logger, State state, long roll, long depth)
        {
            logger.LogError($"{state.Pointer.Debug()} ROL({roll.DebugValue()}, {depth.DebugValue()}) // The roll depth is invalid.");
        }

        public static void ErrorInput(this ILogger logger, State state)
        {
            logger.LogError($"{state.Pointer.Debug()} INP() // Invalid input.");
        }

        public static void Terminated(this ILogger logger, State state, long commands)
        {
            logger.LogWarning($"{state.Pointer.Debug()} EXIT // Terminated after {commands:#,##0} commands.");
        }

        public static void Terminated(this ILogger logger, State state, IEnumerable<Step> route)
        {
            logger.LogWarning($"{state.Pointer.Debug()} EXIT // Terminated on retracing ({string.Join("; ", route.Select(r => r.Point.Debug()))}).");
        }

        public static string DebugValue(this object obj)
        {
            if(obj is char ch)
            {
                if(ch == '\n')
                {
                    return "\\n";
                }
                if (ch == '\t')
                {
                    return "\\t";
                }
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
