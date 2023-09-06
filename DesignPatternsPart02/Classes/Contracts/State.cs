namespace DesignPatternsPart02.Classes.Contracts;

public class State
{
    public Contract Contract { get; private set; }

    public State(Contract contract)
    {
        Contract = contract;
    }
}