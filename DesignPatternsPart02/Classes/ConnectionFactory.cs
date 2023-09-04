using System.Data;
using System.Data.SqlClient;

namespace DesignPatternsPart02.Classes;

public class ConnectionFactory
{
    public IDbConnection GetConnection()
    {
        IDbConnection connection = new SqlConnection();

        connection.ConnectionString = "User=root;Password=root;Server=localhost;Database=myDb";

        connection.Open();

        return connection;
    }
}