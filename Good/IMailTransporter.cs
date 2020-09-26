using ImdSolidPrinciples.Good.Shared;

namespace ImdSolidPrinciples.Good
{
 
    /// <summary>
    /// Responsibility of this interface is: send a message. This class is generic.
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-classes
    /// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods
    /// https://www.dotnetperls.com/generic
    ///
    /// Basically, what we say is: "SendMessage accepts any parameter as long as that parameter implements MessageDto".
    /// </summary>
    public interface IMailTransporter<TMessage> where TMessage : MessageDto
    {
        void SendMessage(TMessage message);
    }
}