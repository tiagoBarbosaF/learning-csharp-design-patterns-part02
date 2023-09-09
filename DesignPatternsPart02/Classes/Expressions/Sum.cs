using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class Sum : IExpression
{
    public IExpression Left { get; private set; }
    public IExpression Right { get; private set; }

    public Sum(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }

    public double Evaluate()
    {
        var leftValue = Left.Evaluate();
        var rightValue = Right.Evaluate();

        return leftValue + rightValue;
    }

    public void Accept(IVisitor printerVisitor) => printerVisitor.PrintSum(this);
    public void OtherAccept(IVisitor printerVisitor) => printerVisitor.PrintOtherFormatSum(this);
}