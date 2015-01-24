//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n

using System;


class ModifyABitAtGivenPosition
{
    static void Main(string[] args)
    {
        int v = 2;
        int a;
        int[] array = new int[32];
        int n;
        int i = 31;
        sbyte p;
        Console.Write("Enter a Number : ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit");
        p = sbyte.Parse(Console.ReadLine());
        while (v != 0 && v != 1)
        {
            Console.WriteLine("Enter value of 'v' (0 or 1)");
            v = int.Parse(Console.ReadLine());
        }
        while (n > 0)
        {
            a = n % 2;
            n = n / 2;
            array[i] = a;
            i--;
        }
        array[(array.Length - 1) - p] = v;
        
        string binaryNumber = "";
        for (int j = 15; j < array.Length; j++)
        {
            binaryNumber = binaryNumber + array[j];
        }
        
        string newDecimalNumber = Convert.ToInt32(binaryNumber, 2).ToString();
        Console.WriteLine(newDecimalNumber);
        
    }
}

