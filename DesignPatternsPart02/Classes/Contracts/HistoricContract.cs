namespace DesignPatternsPart02.Classes.Contracts;

public class HistoricContract
{
    public readonly IList<State> States = new List<State>();

    public void Add(State state) => States.Add(state);
    public State Get(int index) => States[index];
}