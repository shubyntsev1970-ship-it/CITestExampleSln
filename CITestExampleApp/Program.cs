using System;

namespace CITestExampleApp
{
    internal static class Program
    {
        static void Main()
        {

            // Пример использование CI тестов на GitHub Action
            Calculator calculator = new();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Пример использование CI тестов на GitHub Action");
            Console.WriteLine($"10 + 5 = {calculator.Add(10, 5)}");
            Console.WriteLine(new string('-', 50));
        }
    }
}
