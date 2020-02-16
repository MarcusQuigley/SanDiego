using Chap1.AlgorithmicToolbox;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class Lesson2Tests : IDisposable
    {
        Week2 week2;
        Random rand;
        public Lesson2Tests()
        {
            week2 = new Week2();
            rand = new Random();
        }

        public void Dispose() { }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(4, 3)]
        [InlineData(6, 8)]
        public void FibonacciTest(int n, long expectedResult)
        {
            var actualResult = week2.Fibonacci(n);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(4, 3)]
        [InlineData(6, 8)]
        public void FibonacciRecursionTest(int n, long expectedResult)
        {
            var actualResult = week2.FibonacciRecursion(n);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(4, 3)]
        [InlineData(6, 8)]
        public void FibonacciRecursionWithDPTest(int n, long expectedResult)
        {
            var actualResult = week2.FibonacciRecursionWithDP(n);
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
