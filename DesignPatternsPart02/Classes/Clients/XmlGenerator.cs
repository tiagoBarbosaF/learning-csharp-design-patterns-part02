using System.Xml.Serialization;

namespace DesignPatternsPart02.Classes.Clients;

public class XmlGenerator
{
    public string GeneratesXml(object o)
    {
        var serializer = new XmlSerializer(o.GetType());
        var writer = new StringWriter();
        serializer.Serialize(writer, o);
        return writer.ToString();
    }
}