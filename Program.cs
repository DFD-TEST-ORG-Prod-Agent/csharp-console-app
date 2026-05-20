using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
            
            // Simple calculation
            int result = Calculate(10, 5);
            Console.WriteLine($"10 + 5 = {result}");
        }
        
        static int Calculate(int a, int b)
        {
            return a + b;
        }
    }
}
