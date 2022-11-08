using System;

namespace MathematicalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainNumber = 4;
            int secondaryNumber = -2;
            double squaredNumber = Math.Sqrt(mainNumber);
            double poweredNumber = Math.Pow(mainNumber, secondaryNumber);
            double absoluteNumber = Math.Abs(secondaryNumber);

            Console.WriteLine($"Well, the square root of {mainNumber} is equal {squaredNumber}! That's the number!");
            Console.WriteLine($"While {mainNumber} to the power of {secondaryNumber} is equal {poweredNumber}!");
            Console.WriteLine($"Finally, the absolute value of {secondaryNumber} is equal {absoluteNumber}!");

            int a, b, c;
            a = 1;
            b = 12;
            c = -13;
            double delta = Math.Pow(b, 2.0) - 4*a*c;
            Console.WriteLine($"Delta = b² - 4ac can be represented in C#! If a = {a}, b = {b} and c = {c}, we can find out that Delta equals {delta}");
        }
    }
}
