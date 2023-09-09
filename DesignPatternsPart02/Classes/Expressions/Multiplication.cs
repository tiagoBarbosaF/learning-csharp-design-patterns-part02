﻿using DesignPatternsPart02.Classes.Expressions.Interfaces;

namespace DesignPatternsPart02.Classes.Expressions;

public class Multiplication : IExpression
{
    public IExpression Left { get; private set; }
    public IExpression Right { get; private set; }

    public Multiplication(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }

    public double Evaluate()
    {
        var leftValue = Left.Evaluate();
        var rightValue = Right.Evaluate();

        return leftValue * rightValue;
    }

    public void Accept(IVisitor printerVisitor) => printerVisitor.PrintMultiplication(this);
}