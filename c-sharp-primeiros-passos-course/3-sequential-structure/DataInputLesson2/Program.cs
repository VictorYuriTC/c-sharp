using System;
using System.Globalization;

namespace DataInputLesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a random integer.");

            int integerNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a random character.");
            char ch = char.Parse(Console.ReadLine());

            Console.WriteLine("Write a random floating point number.");
            double doubleNumber = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Write a random phrase with 3 words and 1 number. The number has to be an integer placed in the last place of the sentence.");
            string[] vet = Console.ReadLine().Split(' ');
            string randomWord1 = vet[0];
            string randomWord2 = vet[1];
            string randomWord3 = vet[2];
            int randomNumber = int.Parse(vet[3]);
            
            Console.WriteLine($"{integerNumber} was the typed number.");
            Console.WriteLine($"{ch} was the typed character.");
            Console.WriteLine($"{doubleNumber} was the typed floating point number.");
            Console.WriteLine($"I love {randomWord1}, I don't care about {randomWord2} and I have {randomNumber} {randomWord3}");
        }
    }
}
