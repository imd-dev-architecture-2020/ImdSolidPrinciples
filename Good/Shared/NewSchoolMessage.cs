namespace ImdSolidPrinciples.Good.Shared
{
    public class NewSchoolMessage : MessageDto
    {

        public NewSchoolMessage(string msg, string recipient) : base(msg)
        {
            Recipient = recipient;
        }

        public string Recipient { get; set; }

    }
}