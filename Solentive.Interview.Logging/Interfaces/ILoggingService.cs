namespace Solentive.Interview.Logging.Interfaces
{
    public interface ILoggingService
    {
        void LogMessage(string message);
        void LogError(string message);
    }
}
