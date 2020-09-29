using System;

namespace ImdSolidPrinciples.Bad
{
    public class NewSchoolMessage
    {
        public NewSchoolMessage(string message, string somethingToEat)
        {
            Message = message;
            Recipient = somethingToEat;
            CreatedDate = DateTimeOffset.Now;
        }
        public string Message { get; set; }
        public string Recipient { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}