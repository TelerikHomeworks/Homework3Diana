//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0

using System;

class BitwiseExtractBit3
{
    static void Main(string[] args)
    {
        int a;
        int[] array = new int[32];
        int num;
        int i = 31;
        Console.Write("Enter a Number : ");
        num = int.Parse(Console.ReadLine());
        while (num > 0)
        {
            a = num % 2;
            num = num / 2;
            array[i] = a;
            i--;
        }
        if (array[(array.Length - 1) - 3] == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine("1");
        }

    }
}

