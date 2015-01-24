//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBySevenAndFive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        if (num % 5 == 0 && num % 7 == 0)
        {
            Console.WriteLine(num + " can be divided (without remainder) by 7 and 5 at the same time.");
        }
        else
            Console.WriteLine(num + " can't be divided (without remainder) by 7 and 5 at the same time.");
    }
}

