using Microsoft.Extensions.Logging;
using System;

namespace PietDotNet.Logging
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger(LogLevel minLevel = LogLevel.Information)
        {
            MinLevel = minLevel;
        }

        public LogLevel MinLevel { get; }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(LogLevel logLevel) => MinLevel <= logLevel;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Console.Error.WriteLine($"{logLevel} {formatter(state, exception)}");
        }
    }
}
