﻿namespace DesignPatternsPart02.Classes.Expressions.Interfaces;

public interface IExpression
{
    double Evaluate();
    void Accept(IVisitor printerVisitor);
}