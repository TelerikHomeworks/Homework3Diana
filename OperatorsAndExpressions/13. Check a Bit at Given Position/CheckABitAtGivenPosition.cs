//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckABitAtGivenPosition
{
    static void Main(string[] args)
    {
        int a;
        int[] array = new int[32];
        int n;
        int i = 31;
        sbyte p;
        Console.Write("Enter a Number : ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit");
        p = sbyte.Parse(Console.ReadLine());
        while (n > 0)
        {
            a = n % 2;
            n = n / 2;
            array[i] = a;
            i--;
        }
        bool check = array[(array.Length - 1) - p] == 1;
        Console.WriteLine();
        Console.WriteLine(check);
        
    }
}

