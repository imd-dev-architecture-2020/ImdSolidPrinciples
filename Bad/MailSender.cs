using System;

namespace ImdSolidPrinciples.Bad
{
    // This class does everything, and it does everything in one method.
    public class MailSender
    {

        public void SendMessage(object message)
        {
            try
            {
                
                switch (message)
                { 
                    case OldSchoolMessage pm:
                        Console.WriteLine($"Got a message created @ {pm.CreatedDate}, of the type {message.GetType()}");
                        if (string.IsNullOrEmpty(pm.SomethingToEat))
                        {
                            throw new Exception("Pigeon goes on strike, no food was provided.");
                        }
            
                        if (pm.Message.Length > 10)
                        {
                            throw new Exception("Message is too heavy, pigeon can not fly anymore.");
                        }

                        Console.WriteLine($"Swooosh {pm.Message}");
                        break;
                    case NewSchoolMessage mm:
                        Console.WriteLine($"Got a message created @ {mm.CreatedDate}, of the type {message.GetType()}");
                        if (string.IsNullOrEmpty(mm.Recipient))
                        {
                            throw new Exception("No recipient specified");
                        }
                        Console.WriteLine($"Biep boop {mm.Message}");                        
                        break;
                    default:
                        throw new ArgumentException(
                            "Not a recognized message",
                            nameof(message));
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
