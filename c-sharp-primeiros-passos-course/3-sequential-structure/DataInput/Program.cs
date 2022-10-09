using System;

namespace DataInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your first and last name? Please, choose just 2 separated words.");
            string[] username = Console.ReadLine().Split(' ');
            string firstName = username[0];
            string secondName = username[1];
            Console.WriteLine("Do you identify your gender as female or male?");
            string userGender = Console.ReadLine();

            if (userGender == "Female")
            {
                Console.WriteLine($"Welcome, Mrs. {secondName}!");
            }

            if (userGender == "Male")
            {
                Console.WriteLine($"Welcome, Mr. {secondName}!");
            }
            Console.WriteLine("Tap and confirm any key to continue.");
            Console.ReadLine();

            Console.WriteLine($"Nice to meet you! {firstName} is a lovely name.");
            Console.WriteLine($"That's all. Have a nice one!");
        }
    }
}
