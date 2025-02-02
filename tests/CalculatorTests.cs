otnet new xunit -o tests
``

his will create a new xUnit test project in a folder named `tests`.

### Implement Unit Tests

e will create a test class `CalculatorTests.cs` within the `tests` project to test the `Calculator` class.

``diff
using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        public CalculatorTests()
        {
            _calculator = new Calculator();
        }

        [Fact]
        public void Add_TwoValidNumbers_ReturnsSum()
        {
            var result = _calculator.Add("1,2");
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_EmptyInput_ReturnsZero()
        {
            var result = _calculator.Add("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_InvalidNumbers_ReturnsZero()
        {
            var result = _calculator.Add("abc,xyz");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ThrowsException()
        {
            var exception = Assert.Throws<ArgumentException>(() => _calculator.Add("-1,-2"));
            Assert.Equal("Negatives not allowed: -1, -2", exception.Message);
        }

        [Fact]
        public void Add_NumbersGreaterThanThousand_IgnoresThem()
        {
            var result = _calculator.Add("1001,2");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_MixedValidAndInvalidNumbers_ReturnsSumOfValidNumbers()
        {
            var result = _calculator.Add("5,tytyt");
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_CommaOnlyInput_ReturnsZero()
        {
            var result = _calculator.Add(",");
            Assert.Equal(0, result);
        }
    }
}