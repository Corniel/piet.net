using Piet.Interpreting.Logging;

namespace Specs.Tooling;

public class UnitTestLogger(LogLevel minLevel = LogLevel.Info)
    : List<LogRecord>
    , Logger
{
    public LogLevel MinLevel { get; } = minLevel;

    public void Log(LogLevel level, string message)
    {
        if (level < MinLevel) return;

        Add(new LogRecord(level, message));
        TestIO.Error.WriteLine(this.LastOrDefault().Message);
    }
}

public readonly record struct LogRecord(LogLevel Level, string Message)
{
    public override string ToString() => $"{Level} {Message}";
}
