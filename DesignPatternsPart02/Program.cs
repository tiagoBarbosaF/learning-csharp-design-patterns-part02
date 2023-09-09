using DesignPatternsPart02.Classes.Expressions;

namespace DesignPatternsPart02;

internal static class Program
{
    public static void Main(string[] args)
    {
        var left = new Sum(new Number(1), new Number(10));
        var right = new Subtraction(new Number(20), new Number(10));
        var sum = new Sum(left, right);
        
        Console.WriteLine(sum.Evaluate());
        var printer = new PrinterVisitor();
        // sum.Accept(printer);
        sum.OtherAccept(printer);
    }
}