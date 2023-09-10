using DesignPatternsPart02.Classes.Requests.Interfaces;

namespace DesignPatternsPart02.Classes.Requests;

public class PayRequest : ICommand
{
    private Request _request;

    public PayRequest(Request request)
    {
        _request = request;
    }

    public void Execute()
    {
        _request.Pay();
        Console.WriteLine($"Paying the request of client {_request.Client}, payment made on date and time {_request.ProcessDate:g} ");
    }
}