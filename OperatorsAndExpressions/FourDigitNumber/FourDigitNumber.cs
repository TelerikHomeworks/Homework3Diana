//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

using System;

class FourDigitNumber
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Enter number: ");
        int num = int.Parse(Console.ReadLine());
        int d = num % 10;
        num = num - d;
        int c = (num % 100) / 10;
        int b = (num % 1000) / 100;
        int a = (num % 10000) / 1000;
        int sum = a + b + c + d;
        Console.WriteLine("sum = a + b + c + d = " + sum);
        Console.WriteLine(d + "" + c + "" + b + "" + a);
        Console.WriteLine(d + "" + a + "" + b + "" + c);
        Console.WriteLine(a + "" + c + "" + b + "" + d);
    }
}

