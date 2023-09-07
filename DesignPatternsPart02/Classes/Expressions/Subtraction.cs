using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class Subtraction : IExpression
{
    private IExpression _left;
    private IExpression _right;

    public Subtraction(IExpression left, IExpression right)
    {
        _left = left;
        _right = right;
    }

    public double Evaluate()
    {
        var leftValue = _left.Evaluate();
        var rightValue = _right.Evaluate();

        return leftValue - rightValue;
    }
}