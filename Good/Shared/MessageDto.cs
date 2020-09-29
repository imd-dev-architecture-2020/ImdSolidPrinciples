using System;

namespace ImdSolidPrinciples.Good.Shared
{
    // This class contains all the shared properties of a message, regardless whether or not it is an
    //  oldschool, newschool or something else altogether.
    public abstract class MessageDto
    {
        public MessageDto(string msg)
        {
            Message = msg;
            CreatedDate = DateTimeOffset.Now;
        }

        public string Message { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
