//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        int num;
        int a = 0;
        do
        {
            Console.WriteLine("Enter positive integer numer: ");
            num = int.Parse(Console.ReadLine());
        } while (num <= 0 || num > 100);
        for (int i = 2; i <= (num / 2); i++)
        {
            int check = num % i;
            if (check == 0)
            {
                a = 1;
            }
        }
        if ((a == 0 && num != 1) || num == 2)
        {
            Console.WriteLine("Tne number is prime.");
        }
        else
        {
            
                Console.WriteLine("The number isn't prime");
            
        }
    }
}

