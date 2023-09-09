using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class PrinterVisitor : IVisitor
{
    public void PrintSum(Sum sum)
    {
        Console.Write("(");
        sum.Left.Accept(this);
        Console.Write(" + ");
        sum.Right.Accept(this);
        Console.Write(")");
    }

    public void PrintOtherFormatSum(Sum sum)
    {
        Console.Write("+ ");
        sum.Left.Accept(this);
        Console.Write(" ");
        sum.Right.Accept(this);
    }

    public void PrintSubtraction(Subtraction subtraction)
    {
        Console.Write("(");
        subtraction.Left.Accept(this);
        Console.Write(" - ");
        subtraction.Right.Accept(this);
        Console.Write(")");
    }

    public void PrintMultiplication(Multiplication multiplication)
    {
        Console.Write("(");
        multiplication.Left.Accept(this);
        Console.Write(" * ");
        multiplication.Right.Accept(this);
        Console.Write(")");
    }

    public void PrintDivision(Division division)
    {
        Console.Write("(");
        division.Left.Accept(this);
        Console.Write(" / ");
        division.Right.Accept(this);
        Console.Write(")");
    }

    public void PrintSquareRoot(SquareRoot squareRoot)
    {
        Console.Write("(\\u221a");
        squareRoot.Expression.Accept(this);
        Console.Write(")");
    }

    public void PrintNumber(Number number) => Console.Write(number.Value);
}