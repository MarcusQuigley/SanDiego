using Chap1.AlgorithmicToolbox.Exercises;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Chap1.AlgorithmicToolbox.Tests.Exercises
{
    public class Week2ExercisesTests
    {
        Week2Exercises sut;
        public Week2ExercisesTests()
        {
            sut = new Week2Exercises();
        }

        [Theory]
        [InlineData(5,5)]
        [InlineData(7, 13)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        public void CheckFibonacci(int n, int expectedResult)
        {
            var actualResult = sut.Fibonacci(n);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
