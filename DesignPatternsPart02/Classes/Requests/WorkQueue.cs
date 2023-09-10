using DesignPatternsPart02.Classes.Requests.Interfaces;

namespace DesignPatternsPart02.Classes.Requests;

public class WorkQueue
{
    private IList<ICommand> Commands = new List<ICommand>();

    public void Add(ICommand command) => Commands.Add(command);

    public void Process()
    {
        foreach (var command in Commands) command.Execute();
    }
}