using System;

namespace CalculatorApp
{
    public class CalculatorException : Exception
    {
        public CalculatorException(string message) : base(message)
        {
        }
    }
}