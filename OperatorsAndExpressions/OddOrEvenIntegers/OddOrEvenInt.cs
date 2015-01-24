//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEvenInt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0)
        {
            Console.WriteLine(num + "  is even");
        }
        else
            Console.WriteLine(num + " is odd");
    }
}

