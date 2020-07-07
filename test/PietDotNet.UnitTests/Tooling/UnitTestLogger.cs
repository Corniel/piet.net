using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PietDotNet.Tests.Tooling
{
    public class UnitTestLogger : List<LogRecord>, ILogger
    {
        public UnitTestLogger(LogLevel minLevel = LogLevel.Trace) => MinLevel = minLevel;

        public LogLevel MinLevel { get; }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotSupportedException();
        }

        public bool IsEnabled(LogLevel logLevel)=> logLevel >= MinLevel;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (IsEnabled(logLevel))
            {
                Add(new LogRecord(logLevel, formatter.Invoke(state, exception)));
                Console.Error.WriteLine(this.LastOrDefault().Message);
            }
        }
    }

    public struct LogRecord
    {
        public LogRecord(LogLevel level, string message)
        {
            Level = level;
            Message = message;
        }

        public LogLevel Level { get; }
        public string Message { get; }

        public override string ToString() => $"{Level} {Message}";
    }
}
