using DesignPatternsPart02.Classes.Requests.Enums;

namespace DesignPatternsPart02.Classes.Requests;

public class Request
{
    public string Client { get; private set; }
    public double Value { get; private set; }
    public DateTime ProcessDate { get; private set; }
    public DateTime FinishDate { get; private set; }
    public Status Status { get; private set; }

    public Request(string client, double value)
    {
        Client = client;
        Value = value;
        Status = Status.New;
        ProcessDate = DateTime.Now;
    }

    public void Pay()
    {
        Status = Status.Paid;
        ProcessDate = DateTime.Now;
    }

    public void Finish()
    {
        Status = Status.Delivered;
        FinishDate = DateTime.Now;
    }
}