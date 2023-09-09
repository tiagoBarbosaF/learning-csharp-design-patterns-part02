using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class SquareRoot : IExpression
{
    public IExpression Expression { get; private set; }

    public SquareRoot(IExpression expression)
    {
        Expression = expression;
    }

    public double Evaluate()
    {
        return Math.Sqrt(Expression.Evaluate());
    }

    public void Accept(IVisitor printerVisitor) => printerVisitor.PrintSquareRoot(this);
}