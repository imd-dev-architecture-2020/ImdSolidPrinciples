using System;

namespace ImdSolidPrinciples.Bad
{
    public class OldSchoolMessage
    {
        public OldSchoolMessage(string message, string somethingToEat)
        {
            Message = message;
            SomethingToEat = somethingToEat;
            CreatedDate = DateTimeOffset.Now;
        }

        public string Message { get; set; }
        public string SomethingToEat { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}