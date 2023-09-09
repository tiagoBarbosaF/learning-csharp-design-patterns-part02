using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class MessageAdministrative : IMessage
{
    private string _name;
    public ISender Sender { get; set; }

    public MessageAdministrative(string name)
    {
        _name = name;
    }

    public void Send() => Sender.Send(this);

    public string Format() => $"Sending message for administrator {_name}";
}