using DesignPatternsPart02.Classes.Expressions;

namespace DesignPatternsPart02;

internal static class Program
{
    public static void Main(string[] args)
    {
        var messageAdmin = new MessageAdministrative("Tiago");
        var messageClient = new MessageClient("Tiago");
        var senderSms = new SendingBySms();
        var senderEmail = new SendingByEmail();
        messageAdmin.Sender = senderSms;
        messageAdmin.Send();

        messageClient.Sender = senderEmail;
        messageClient.Send();
    }
}