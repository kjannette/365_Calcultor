namespace CalculatorApp
{
    public class Calculator
    {
        // Method to add two numbers from a comma-separated string
        public int Add(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            string[] parts = input.Split(',');

            if (parts.Length > 2)
            {
                throw new CalculatorException("More than two numbers provided.");
            }

            int[] numbers = parts.Select(ParseNumber).ToArray();

            return numbers.Sum();
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