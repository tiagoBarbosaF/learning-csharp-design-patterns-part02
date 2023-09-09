using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class Number : IExpression
{
    public int Value { get; private set; }

    public Number(int number) => Value = number;

    public double Evaluate() => Value;

    public void Accept(IVisitor printerVisitor) => printerVisitor.PrintNumber(this);
}