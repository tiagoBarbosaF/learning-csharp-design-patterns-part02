namespace DesignPatternsPart02.Classes.Expressions.Interfaces;

public interface IMessage
{
    ISender Sender { get; set; }
    void Send();
    string Format();
}