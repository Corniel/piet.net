namespace Piet.Interpreting.Logging;

public interface Logger
{
    static Logger Console(LogLevel minLevel = LogLevel.Info) => new ConsoleInOut(minLevel);

    LogLevel MinLevel { get; }

    void Log(LogLevel level, string message);

    private sealed class ConsoleInOut(LogLevel minLevel) : Logger
    {
        public LogLevel MinLevel { get; } = minLevel;

        public void Log(LogLevel level, string message)
        {
            if (level < MinLevel) return;
            System.Console.Error.WriteLine($"{level} {message}");
        }
    }
}
