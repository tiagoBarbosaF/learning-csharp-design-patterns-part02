using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class SendingByEmail : ISender
{
    public void Send(IMessage message)
    {
        Console.WriteLine("Sending message by email");
        Console.WriteLine(message.Format());
    }
}