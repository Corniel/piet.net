namespace PietDotNet.Logging;

public interface Logger
{
    void Log(LogLevel level, string message);
}
