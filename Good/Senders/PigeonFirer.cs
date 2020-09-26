using System;
using ImdSolidPrinciples.Good.Shared;

namespace ImdSolidPrinciples.Good.Senders
{
    public class PigeonFirer : IMailTransporter<OldSchoolMessage>
    {
        private readonly ILogger _logger;

        public PigeonFirer(ILogger logger)
        {
            _logger = logger;
        }

        public void SendMessage(OldSchoolMessage message)
        {
            if (string.IsNullOrEmpty(message.SomethingToEat))
            {
                throw new Exception("Pigeon goes on strike, no food was provided.");
            }
            
            if (message.Message.Length > 10)
            {
                throw new Exception("Message is too heavy, pigeon can not fly anymore.");
            }

            _logger.LogMessage($"Swooosh {message.Message}");
        }
    }
}