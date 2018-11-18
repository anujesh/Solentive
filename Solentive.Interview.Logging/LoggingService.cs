using System.IO;
using System.Web.Hosting;
using Solentive.Interview.Logging.Interfaces;

namespace Solentive.Interview.Logging
{
    public class LoggingService : ILoggingService
    {
        public void LogError(string message)
        {
            var path = Path.Combine(HostingEnvironment.MapPath("~/Logs"), "error.txt");
            Log(message, path);
        }

        public void LogMessage(string message)
        {
            var path = Path.Combine(HostingEnvironment.MapPath("~/Logs"), "log.txt");
            Log(message, path);
        }

        public static void Log(string message, string path)
        {
            using (var stream = new FileStream(path, FileMode.Append))
            {
                var writer = new StreamWriter(stream);
                writer.WriteLine(message);
                writer.Flush();
            }
        }

    }
}