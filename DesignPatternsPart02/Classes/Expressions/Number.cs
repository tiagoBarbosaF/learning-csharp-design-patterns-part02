using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class Number : IExpression
{
    private int _number;

    public Number(int number)
    {
        _number = number;
    }

    public double Evaluate()
    {
        return _number;
    }
}