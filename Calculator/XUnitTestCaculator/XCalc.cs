using System;
using Xunit;
using Calculator;

namespace XUnitTestCaculator
{
    public class XCalc
    {
        [Fact]
        public void TestAdd()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 6.0;
            double actual = calc.Add(4.0, 2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDivide()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 2.0;
            double actual = calc.Divide(4.0, 2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestSubtract()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 3.0;
            double actual = calc.Subtract(5.0, 2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMultiply()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 10.0;
            double actual = calc.Multiply(5.0, 2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestModular()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 0.0;
            double actual = calc.Modular(6.0, 3.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCircleA()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 12.568;
            double actual = calc.CircleA(2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestTriangleA()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 18;
            double actual = calc.TriangleA(4.0, 9.0);
            Assert.Equal(expected, actual);
        }
    }
}
