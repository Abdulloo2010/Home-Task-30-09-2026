using Domain;
using Domain.Models;
Cache<string>.Add("Abdullo");
Cache<string>.Add("Ali");
Cache<string>.Remove("Ali");
List<string> c = Cache<string>.Get();
foreach (var item in c)
{
    Console.WriteLine(item);
}

// 2
Console.WriteLine("============ Task 2 ============");
Console.WriteLine("------------ Circle!: ");
Console.WriteLine(Circle.CalcCircleArea(23));
Console.WriteLine(Circle.CalcCirclePerimeter(4));

Console.WriteLine("------------ Rectangle!: ");
Console.WriteLine(Rectangle.CalcRectangleArea(3,4));
Console.WriteLine(Rectangle.CalcRectanglePerimeter(3,2));

Console.WriteLine("------------ Triangle!: ");
Console.WriteLine(Triangle.CalcTriangleArea(2,2));
Console.WriteLine(Triangle.CalcTrianglePerimeter(2,3,4));

// 3
Console.WriteLine("============ Task 3 ============");
Console.WriteLine(Maths.add(5,5));
Console.WriteLine(Maths.Subtract(3,3));
Console.WriteLine(Maths.Multiply(5,4));
Console.WriteLine(Maths.Divide(3,6));