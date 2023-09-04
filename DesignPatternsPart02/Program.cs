using DesignPatternsPart02.Classes;

internal class Program
{
    public static void Main(string[] args)
    {
        var connection = new ConnectionFactory().GetConnection();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM PERSON";
    }
}

