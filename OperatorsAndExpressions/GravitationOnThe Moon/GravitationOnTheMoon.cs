//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
using System;

class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter weight of the man on the moon: ");
        float weightOnTheEarth = float.Parse(Console.ReadLine());
        float weightOnTheMoon = weightOnTheEarth * 17 / 100;
        Console.WriteLine("weight of the man on the moon is: " + weightOnTheMoon);
    }
}

