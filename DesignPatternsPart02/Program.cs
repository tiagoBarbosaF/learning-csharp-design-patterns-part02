using DesignPatternsPart02.Classes.Clients;

namespace DesignPatternsPart02;

internal static class Program
{
    public static void Main(string[] args)
    {
        var client = new Client() { Name = "Tiago", Address = "Street Test", Birthdate = DateTime.Now };

        var xml = new XmlGenerator().GeneratesXml(client);
        
        Console.WriteLine(xml);
    }
}