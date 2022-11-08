using System;

namespace DataProcessingAndCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d;
            double intResult, result;

            a = 5;
            b = 2;
            d = 4;
            c = (int) d;

            intResult = a / b;
            result = (double) a / b;

            Console.WriteLine(intResult);

            Console.WriteLine(result);

            Console.WriteLine(d);
        }
    }
}
