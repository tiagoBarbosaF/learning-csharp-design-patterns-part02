using DesignPatternsPart02.Classes.Expressions;

internal class Program
{
    public static void Main(string[] args)
    {
        // var left = new Sum(new Sum(new Number(1), new Number(100)), new Number(10));
        // var right = new Subtraction(new Number(20), new Number(10));
        // var sum = new Sum(left, right);
        //
        // Console.WriteLine(sum.Evaluate());

        // var sum = Expression.Add(Expression.Constant(10), Expression.Constant(100));
        // var function = Expression.Lambda<Func<int>>(sum).Compile();
        //
        // Console.WriteLine(function());

        var left = new Multiplication(new Number(5), new Number(5));
        var right = new Division(new Number(9), new Number(3));
        
        Console.WriteLine(left.Evaluate());
        Console.WriteLine(right.Evaluate());
    }
}