using Xunit;
using CalculatorApp;
using System;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            // Arrange
            var calculator = new Calculator();
            string input = "1,2";

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_MoreThanTwoNumbers_ThrowsException()
        {
            // Arrange
            var calculator = new Calculator();
            string input = "1,2,3";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => calculator.Add(input));
        }

        [Fact]
        public void Add_InvalidCharacters_ReturnsSumIgnoringInvalid()
        {
            // Arrange
            var calculator = new Calculator();
            string input = "5,tytyt";

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ThrowsException()
        {
            // Arrange
            var calculator = new Calculator();
            string input = "-1,2";

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => calculator.Add(input));
            Assert.Contains("Negatives not allowed", exception.Message);
        }

        [Fact]
        public void Add_NumbersGreaterThan1000_IgnoresThem()
        {
            // Arrange
            var calculator = new Calculator();
            string input = "2,1001";

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_EmptyInput_ReturnsZero()
        {
            // Arrange
            var calculator = new Calculator();
            string input = "";

            // Act
            int result = calculator.Add(input);

            // Assert
            Assert.Equal(0, result);
        }
    }
}