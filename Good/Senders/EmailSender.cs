using System;
using ImdSolidPrinciples.Good.Shared;

namespace ImdSolidPrinciples.Good.Senders
{
    public class EmailSender : IMailTransporter<NewSchoolMessage>
    {
        private readonly ILogger _logger;

        public EmailSender(ILogger logger)
        {
            _logger = logger;
        }

        public void SendMessage(NewSchoolMessage message)
        {
            if (string.IsNullOrEmpty(message.Recipient))
            {
                throw new Exception("No recipient specified");
            }
            _logger.LogMessage($"Biep boop {message.Message}");
        }
    }
}