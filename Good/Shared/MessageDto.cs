using System;

namespace ImdSolidPrinciples.Good.Shared
{
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
