//Write an expression that checks for given integer if its third digit from right-to-left is 7

using System;

class IsThirdDigitSeven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int remainder = num % 100;
        num = num - remainder;
        remainder = num % 1000;
        int num1 = remainder / 100;
        Boolean thirdDigitIsSeven = num1 == 7;
        if (thirdDigitIsSeven)
        {
            Console.WriteLine("The number's third digit is seven");
        }
        else
        {
            Console.WriteLine("The number's third digit isn't seven");
        }
    }
}

