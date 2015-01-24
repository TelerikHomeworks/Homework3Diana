//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2)
using System;

class PointInACircle
{
    static void Main(string[] args)
    {
//От питагоровата теорема a*a + b*b = c*c => ,че за да е точката вътре в кръга, то x*x + y*y следва да е по-малко или равно на 2 * 2 = 4.
        int c = 4;
        Console.WriteLine("Enter x: ");
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter y: ");
        float y = float.Parse(Console.ReadLine());
        Boolean chek = (x * x + y * y) <= c;
        if (chek)
        {
            Console.WriteLine("the point (" + x + " , " + y + ") is inside a circle K({0, 0}, 2)");
        }
        else
        {
            Console.WriteLine("the point (" + x + " , " + y + ") isn't inside a circle K({0, 0}, 2)");
        }
    }
}

