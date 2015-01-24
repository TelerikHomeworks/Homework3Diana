//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class BitExchangeAdvanced
{
    static void Main(string[] args)
    {
        int value;
        string binaryNumber = "";
        int n;
        int i = 31;
        int a;
        int p;
        int q;
        int k;
        int[] array = new int[32];
        Console.Write("Enter a Number : ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit (p) : ");
        p = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit (q) : ");
        q = int.Parse(Console.ReadLine());
        Console.Write("Enter k :");
        k = int.Parse(Console.ReadLine());

        while (n > 0)
        {
            a = n % 2;
            n = n / 2;
            array[i] = a;
            i--;
        }
        for (int j = array.Length - 1 - p, z = array.Length - 1 - q; j >= (array.Length - 1 - p - k) && z > (array.Length - 1 - q - k); j--, z--)
        {
            value = array[j];
            array[j] = array[z];
            array[z] = value;
        }
        for (int m = 0; m < array.Length; m++)
        {
            binaryNumber = binaryNumber + array[m];
        }
        string newDecimalNumber = Convert.ToInt32(binaryNumber, 2).ToString();
        Console.WriteLine(newDecimalNumber);
    }

}

