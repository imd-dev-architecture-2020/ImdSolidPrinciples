namespace ImdSolidPrinciples.Good.Shared
{
    public class OldSchoolMessage : MessageDto
    {
        public OldSchoolMessage(string msg, string somethingToEat) : base(msg)
        {
            SomethingToEat = somethingToEat;
        }

        public string SomethingToEat { get; set; }

    }
}