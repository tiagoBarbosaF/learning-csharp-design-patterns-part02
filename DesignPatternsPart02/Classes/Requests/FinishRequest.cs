using DesignPatternsPart02.Classes.Requests.Interfaces;

namespace DesignPatternsPart02.Classes.Requests;

public class FinishRequest : ICommand
{
    private Request _request;

    public FinishRequest(Request request)
    {
        _request = request;
    }

    public void Execute()
    {
        _request.Finish();
        Console.WriteLine($"Finishing the request of client {_request.Client}, payment finished on date and time {_request.FinishDate.Add(TimeSpan.FromMinutes(30)):g}");
    }
}