using PietDotNet.Logging;

namespace PietDotNet.Tests.Tooling;

public class UnitTestLogger : List<LogRecord>, Logger
{
    public UnitTestLogger(LogLevel minLevel = LogLevel.Info) => MinLevel = minLevel;

    public LogLevel MinLevel { get; }

    public void Log(LogLevel level, string message)
    {
        if (level < MinLevel) return;

        Add(new LogRecord(level, message));
        Console.Error.WriteLine(this.LastOrDefault().Message);
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
