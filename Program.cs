using System;
using System.Collections.Generic;
using ImdSolidPrinciples.Good.Senders;
using ImdSolidPrinciples.Good.Shared;
using ImdSolidPrinciples.Good.Utils;

namespace ImdSolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            // first testing the good parts
            var logger = new Logger();
            var dovecote = new PigeonFirer(logger);
            var mailRelay = new EmailSender(logger);
            var goodSender = new Good.MailSender(dovecote, mailRelay, logger);
            var messages = new List<MessageDto>()
            {
                new NewSchoolMessage("Hiya", "raf.ceuls@thomasmore.be"),
                new NewSchoolMessage("Hiya 2", string.Empty),
                new OldSchoolMessage("Hiya 2", "Grains"),
                new OldSchoolMessage("Hiya 2 abcdefg", "Grains"),
                new OldSchoolMessage("Hdfd", null),
            };

            messages.ForEach(x =>
            {
                // notice we can only send objects which are of a class that implements "MessageDto"
                goodSender.SendMessage(x);
            });

            // compile time error
            // goodSender.SendMessage("blep");

            Console.WriteLine("Finished testing the good implementation");
            var badSender = new Bad.MailSender();
            var messagesBad = new List<object>()
            {
                new Bad.NewSchoolMessage("Hiya", "raf.ceuls@thomasmore.be"),
                new Bad.NewSchoolMessage("Hiya 2", string.Empty),
                new Bad.OldSchoolMessage("Hiya 2", "Grains"),
                new Bad.OldSchoolMessage("Hiya 2 abcdefg", "Grains"),
                new Bad.OldSchoolMessage("Hdfd", null),
                "string blep",
                12,
                new Exception("grmbl")
            };
            messagesBad.ForEach(x =>
            {
                // accepts whatever you throw at it
                badSender.SendMessage(x);
            });

            Console.ReadLine();
        }
    }
}
