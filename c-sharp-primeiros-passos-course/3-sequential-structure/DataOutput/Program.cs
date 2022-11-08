using System;
using System.Globalization;

namespace DataOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            Console.Write("No break rule with Console.Write. See?");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Now, I have to go. First, what's your name?");
            string answeredName = Console.ReadLine();
            Console.WriteLine($"Alright, {answeredName} then.");
            Console.WriteLine("So thank you, " + answeredName + ". Bye!");
        }
    }
}
