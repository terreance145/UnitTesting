using System;
using Xunit;
using UnitTesting;

namespace UnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4 , 5, 9)]
        [InlineData(2, 6, 8)]
        [InlineData(-21, 8, -13)]
        [InlineData(-4, -6, 10)]


        public void DoesAdd(int number1, int number2, int expectedValue)
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int actualResult = calc.Add(number1, number2);

            //Assert
            Assert.Equal(expectedValue, actualResult);
        }

        [Theory]
        [InlineData(2, 1, 3)]
        [InlineData(91, 1, 90)]
        [InlineData(-30, 15, -15)]
        [InlineData(2, 11, -9)]




        public void DoesSubtract(int num1, int num2, int expectedValue)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act

            int actualResult = calc.Subtract(num1, num2);

            //Assert
            Assert.Equal(expectedValue, actualResult);

        }


        [Theory]
        [InlineData(22, 1, 22)]
        [InlineData(91, 1, 91)]
        [InlineData(30, 5, 150)]
        [InlineData(2, 11, -9)]




        public void DoesMultiply(int num1, int num2, int expectedValue)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act

            int actualResult = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expectedValue, actualResult);

        }
        [Theory]
        [InlineData(4, 2, 4)]
        [InlineData(10, 2, 5)]
        [InlineData(300, 100, 3)]
        [InlineData(100, 2, 50)]




        public void DoesDivide(int num1, int num2, int expectedValue)
        {
            //Arrange
            Calculator calc = new Calculator();


            //Act

            int actualResult = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expectedValue, actualResult);

        }

    }

}
