using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class SendingBySms: ISender
{
    public void Send(IMessage message)
    {
        Console.WriteLine("Sending message by SMS");
        Console.WriteLine(message.Format());
    }
}