namespace ImdSolidPrinciples.Good
{
    /// <summary>
    /// The responsibility of this interface is: give the user feedback.
    /// </summary>
    public interface ILogger
    {
        void LogError(string error);
        void LogMessage(string message);
    }
}