//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the width: ");
        float width = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height: ");
        float height = float.Parse(Console.ReadLine());
        float perimeter = 2 * (width + height);
        float area = width * height;
        Console.WriteLine("P = 2 * (a + b) = " + perimeter);
        Console.WriteLine("S = a * b = " + area);

    }
}

