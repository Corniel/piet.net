namespace PietDotNet.Logging;

public interface Logger
{
    LogLevel MinLevel { get; }

    void Log(LogLevel level, string message);
}
