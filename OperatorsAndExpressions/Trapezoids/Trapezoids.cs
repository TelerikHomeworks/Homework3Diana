//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a: ");
        float a = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        float b = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter h: ");
        float h = float.Parse(Console.ReadLine());
        float area = (a + b) * h / 2;
        Console.WriteLine("S = (a + b) * h / 2 = " + area);
    }
}

