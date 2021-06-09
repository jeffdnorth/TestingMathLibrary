using System;
using TestingMathLibrary;
using Xunit;

namespace TestMathLibrary
{
    public class TestMathLibrary
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(6, 2, 8)]
        [InlineData(int.MaxValue, int.MinValue, -1)]
        public void TestAdd(int i, int j, int ans)
        {
            var mathLib = new MathLibrary();
            Assert.Equal(ans, mathLib.Add(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestSubtract(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            Assert.Equal(ans, mathlib.Subtract(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestMultiply(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            Assert.Equal(ans, mathlib.Multiply(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(6, 3, 2)]
        [InlineData(1, 0, 0)]
        public void TestDivide(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            if(j == 0)
            {
                Assert.ThrowsAny<DivideByZeroException>(() => mathlib.Divide(i, j));
                return;
            }
            Assert.Equal(ans, mathlib.Divide(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 4)]
        public void TestPower(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            Assert.Equal(ans, mathlib.Power(i, j));
        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestSquare(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            Assert.Equal(ans, mathlib.Square(i, j));

        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestFactorial(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            Assert.Equal(ans, mathlib.Factorial(i, j));

        }

        [Theory]
        [InlineData(1, 2, -1)]
        public void TestModulo(int i, int j, int ans)
        {
            var mathlib = new MathLibrary();
            Assert.Equal(ans, mathlib.Modulo(i, j));

        }
    }
}
