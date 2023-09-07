using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class SquareRoot : IExpression
{
    private IExpression _expression;

    public SquareRoot(IExpression expression)
    {
        _expression = expression;
    }

    public double Evaluate()
    {
        return Math.Sqrt(_expression.Evaluate());
    }
}