namespace DesignPatternsPart02.Classes.Contracts;

public class Contract
{
    public DateTime Date { get; private set; }
    public string Client { get; private set; }
    public TypeContract Type { get; private set; }

    public Contract(DateTime date, string client, TypeContract type)
    {
        Date = date;
        Client = client;
        Type = type;
    }

    public void Advance()
    {
        if (Type == TypeContract.New)
            Type = TypeContract.InProgress;
        else if (Type == TypeContract.InProgress)
            Type = TypeContract.Agreed;
        else if (Type == TypeContract.Agreed)
            Type = TypeContract.Concluded;
        else
            Type = TypeContract.Concluded;
    }

    public State SaveState() => new(new Contract(Date, Client, Type));

    public void Restore(State state)
    {
        Date = state.Contract.Date;
        Client = state.Contract.Client;
        Type = state.Contract.Type;
    }
}