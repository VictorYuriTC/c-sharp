using System;

namespace VariablesAndBasicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte age = 24;
            string name = "Victor";
            double height = 1.74;
            long deaths = 394593809479834;
            string camelCase = "In c#, camelCase is recommended for variables";
            Console.WriteLine($"Hello! My name is {name}, I'm {age}, I'm {height} meters tall and I've died {deaths} times botside.");
            Console.WriteLine($"{camelCase}");
        }
    }
}
