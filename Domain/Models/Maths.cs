namespace Domain.Models;

public static class Maths
{
    public static double add(double a, double b)
    {
        return a+b;
    }

    public static double Subtract(double a, double b)
    {
        if (a < b)
        {
            Console.WriteLine("a must be greater than b");
            return 0;
        }

        return a-b;
    }

    public static double Multiply(double a, double b)
    {
        return a*b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
            return 0;
        }
        return a/b;
    }
}
