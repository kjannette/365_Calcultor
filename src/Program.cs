using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to add, separated by a comma (or other delimiter) (e.g., 1,2):");
            string input = Console.ReadLine();

            try
            {
                Calculator calculator = new Calculator();
                int result = calculator.Add(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (CalculatorException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
