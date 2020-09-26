using System;

namespace ImdSolidPrinciples.Good.Utils
{
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