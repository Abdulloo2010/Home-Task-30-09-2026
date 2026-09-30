namespace Domain.Models;

public class Triangle
{
    public static double CalcTriangleArea(double bas, double height)
    {
        return 0.5*bas*height;
    }

    public static double CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1+side2+side3;
    }
}
