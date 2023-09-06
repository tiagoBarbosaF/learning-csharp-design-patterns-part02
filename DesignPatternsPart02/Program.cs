using DesignPatternsPart02.Classes;
using DesignPatternsPart02.Classes.Contracts;
using DesignPatternsPart02.Classes.Piano;
using DesignPatternsPart02.Classes.Piano.Interfaces;

internal class Program
{
    public static void Main(string[] args)
    {
        var historic = new HistoricContract();
        var contract = new Contract(DateTime.Now, "tiago", TypeContract.New);

        historic.Add(contract.SaveState());
        
        contract.Advance();
        historic.Add(contract.SaveState());
        contract.Advance();
        historic.Add(contract.SaveState());
        
        Console.WriteLine(historic.States.Count);
        Console.WriteLine(historic.Get(0).Contract.Type);
        Console.WriteLine(historic.Get(1).Contract.Type);
        Console.WriteLine(historic.Get(2).Contract.Type);
    }
}