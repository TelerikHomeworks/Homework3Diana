//Write an expression that extracts from given integer n the value of given bit at index p

using System;

class ExtractBitfromInteger
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

        if (array[(array.Length - 1) - p] == 0)
        {
            Console.WriteLine();
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("1");
        }
    }
}

