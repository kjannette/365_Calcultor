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

            string[] parts = input.Split(',', '\n', '#');

           
            return parts.Select(ParseNumber).Sum();
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