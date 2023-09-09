using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class MessageClient : IMessage
{
    private string _name;
    public ISender Sender { get; set; }

    public MessageClient(string name)
    {
        _name = name;
    }


    public void Send() => Sender.Send(this);

    public string Format() => $"Sending message for client {_name}";
}