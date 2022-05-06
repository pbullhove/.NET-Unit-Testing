using System;
using BasicProgram;
using NUnit.Framework;

namespace UnitTestPractise.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Add_EitherOrBothArgumentsAreNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _calculator.Add(null, null),Throws.TypeOf<ArgumentNullException>());
            Assert.That(() => _calculator.Add(1, null),Throws.TypeOf<ArgumentNullException>());
            Assert.That(() => _calculator.Add(null, 1),Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        [TestCase(0,0,0)]
        [TestCase(1,1,2)]               
        [TestCase(-1,0,-1)]
        public void Add_ArgumentsAreValid_ReturnsSumOfArguments(int first, int second, int expectedResult)
        {
            var result = _calculator.Add(first, second);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}