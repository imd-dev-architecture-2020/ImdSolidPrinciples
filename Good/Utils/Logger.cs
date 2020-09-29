using System;

namespace ImdSolidPrinciples.Good.Utils
{
    // Very naive. In real life you'd have an Logger with a bunch of logsinks going to a persistent logging system.
    // (grafana-via-STDOUT, sentry, ... )
    public class Logger : ILogger
    {
        public void LogError(string error)
        {
            Console.Error.WriteLine(error);
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}