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

        [Theory]
        [InlineData(15, 0)]
        [InlineData(7, 3)]
        [InlineData(11, 9)]
        [InlineData(2, 1)]
        [InlineData(13, 3)]
        [InlineData(331, 9)]
        public void CheckLastDigitOfFibonacci(int n, int expectedResult)
        {
            var actualResult = sut.LastDigitOfFibonacci(n);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 1344, 217 }, 7)]
        [InlineData(new int[] { 18, 35 }, 1)]
        [InlineData(new int[] { 28851538, 1183019 }, 17657)]
        [InlineData(new int[] { 3918848, 1653264 }, 61232)]
        public void CheckGreatestCommonDivisor(int[] values, int expectedResult)
        {
            var actualResult = sut.GreatestCommonDivisor(values);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
         [InlineData(new int[] { 6,8 }, 24)]
       [InlineData(new int[] { 18, 35 }, 630)]
         [InlineData(new int[] { 28851538, 1183019 }, 1933053046)]
         [InlineData(new int[] { 2, 5 }, 10)]
        public void CheckLeastCommonMultiple(int[] values, int expectedResult)
        {
            var actualResult = sut.LeastCommonMultipleBruteForce(values);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
