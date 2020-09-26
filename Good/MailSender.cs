using System;
using System.Net.Mail;
using ImdSolidPrinciples.Good.Shared;
using ImdSolidPrinciples.Good.Utils;

namespace ImdSolidPrinciples.Good
{
    /// <summary>
    /// The responsibility of this class is "dispatch a message to the correct sender and handle whatever error it throws.
    /// </summary>
    public class MailSender
    {
        private readonly IMailTransporter<OldSchoolMessage> _oldSchoolMailTransporter;
        private readonly IMailTransporter<NewSchoolMessage> _newSchoolMailTransporter;
        private readonly ILogger _logger;

        // notice pass interfaces here, i.e. we program to an abstraction.
        // we pass a lot of interfaces 
        public MailSender(IMailTransporter<OldSchoolMessage> oldSchoolMailTransporter, IMailTransporter<NewSchoolMessage> newSchoolMailTransporter, ILogger logger)
        {
            // needed for sending old school messages
            _oldSchoolMailTransporter = oldSchoolMailTransporter;
            // needed for sending new messages
            _newSchoolMailTransporter = newSchoolMailTransporter;
            // provide output to the user
            _logger = logger;
        }

        public void SendMessage(MessageDto message)
        {
            try
            {
                _logger.LogMessage("Got a message created @ " + message.CreatedDate + ", of the type " + message.GetType());
                // pattern matching: https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
                switch (message)
                {
                    case OldSchoolMessage pm:
                        _oldSchoolMailTransporter.SendMessage(pm);
                        break;
                    case NewSchoolMessage mm:
                        _newSchoolMailTransporter.SendMessage(mm);
                        break;
                    default:
                        // if you "print" an object, you will get either the TypeName or the ToString()
                        throw new ArgumentException(
                            $"Not a recognized message, got a {message}",
                            nameof(message));
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }
        }
    }
}
