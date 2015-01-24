//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer

using System;

class BitsExchange
{
    static void Main(string[] args)
    {
        int value;
        string binaryNumber = "";
        int n;
        int i = 31;
        int a;
        int[] array = new int[32];
        Console.Write("Enter a Number : ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            a = n % 2;
            n = n / 2;
            array[i] = a;
            i--;
        }
        for (int j = 7, k = 28; j > 4 && k > 25; j--, k--)
        {
            value = array[j];
            array[j] = array[k];
            array[k] = value;
        }
        for (int m = 0; m < array.Length; m++)
        {
            binaryNumber = binaryNumber + array[m];
        }
        string newDecimalNumber = Convert.ToInt32(binaryNumber, 2).ToString();
        Console.WriteLine(newDecimalNumber);
    }
}

