using System;
using NUnit.Framework;

namespace StringCalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpTests()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Should_ReturnZero_When_GivenAnEmptyString()
        {
            var input = string.Empty;
            var result = calculator.Add(input);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Should_ReturnEnteredNumber_When_ANumberIsEntered()
        {
            const string input = "1";
            var result = calculator.Add(input);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Should_AddTwoNumbersTogether_When_TwoNumbersAreEntered()
        {
            throw new NotImplementedException();
            
        }
}
        public class Calculator
        {
            public int Add(string input)
            {
                return input == string.Empty ? 0 : int.Parse(input);
            }
        }
    
}
