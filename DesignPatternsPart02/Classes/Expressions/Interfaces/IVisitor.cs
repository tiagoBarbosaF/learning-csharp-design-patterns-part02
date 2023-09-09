namespace DesignPatternsPart02.Classes.Expressions.Interfaces;

public interface IVisitor
{
    void PrintSum(Sum sum);
    void PrintOtherFormatSum(Sum sum);
    void PrintSubtraction(Subtraction subtraction);
    void PrintMultiplication(Multiplication multiplication);
    void PrintDivision(Division division);
    void PrintSquareRoot(SquareRoot squareRoot);
    void PrintNumber(Number number);
}