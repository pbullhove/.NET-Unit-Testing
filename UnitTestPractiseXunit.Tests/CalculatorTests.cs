using System;
using BasicProgram;
using Xunit;

namespace UnitTestPractiseXunit.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calculator;

        // Xunit creates a new instance of the class for every test, so this is okay to create in constructor. 
        public CalculatorTests()
        {
            _calculator = new Calculator(); 
        }
        [Fact]
        public void Add_ArgumentsAreNull_ThrowsInvalidArgumentException()
        {
            Assert.Throws<ArgumentNullException>(() => _calculator.Add(null, null));
        }

        [Theory]
        [InlineData(0,0,0)]
        [InlineData(1, 1, 2)]
        [InlineData(-1, 0, -1)]
        public void Add_ValidInput_ReturnsSumOfArguments(int first, int second, int expectedResult)
        {
            var result = _calculator.Add(first, second); 
            
            Assert.Equal(expectedResult, result);
        }
    }
}