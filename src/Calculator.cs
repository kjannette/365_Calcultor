namespace CalculatorApp
{
    using System.Text.RegularExpressions;
    public class Calculator
    {
        // Method to add two numbers from a comma-separated string
        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) // Check for empty input
            {
                return 0;
            }

            // Split the input string on any sequence of non-number characters
            string[] parts = Regex.Split(input, @"\D+");

           
            var numbers = parts.Select(ParseNumber).ToList();

            // Identify negative numbers
            var negativeNumbers = numbers.Where(n => n < 0).ToList();
            if (negativeNumbers.Any())
            {
                throw new ArgumentException($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }

            // Filter out numbers greater than 1000
            return numbers.Where(n => n <= 1000).Sum();
        }

        // Helper method to parse a number, converting invalid inputs to 0
        private int ParseNumber(string input)
        {
            if (int.TryParse(input.Trim(), out int number))
            {
                return number;
            }
            return 0;
        }
    }
}