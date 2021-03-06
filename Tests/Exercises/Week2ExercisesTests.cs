﻿using Chap1.AlgorithmicToolbox.Exercises;
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
        [InlineData(5, 5)]
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
        [InlineData(new int[] { 6, 8 }, 24)]
        [InlineData(new int[] { 18, 35 }, 630)]
        [InlineData(new int[] { 28851538, 1183019 }, 1933053046)]
        [InlineData(new int[] { 2, 5 }, 10)]
        public void CheckLeastCommonMultipleBruteForce(int[] values, int expectedResult)
        {
            var actualResult = sut.LeastCommonMultipleBruteForce(values);
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(new int[] { 6, 8 }, 24)]
        [InlineData(new int[] { 18, 35 }, 630)]
        [InlineData(new int[] { 28851538, 1183019 }, 1933053046)]
        [InlineData(new int[] { 2, 5 }, 10)]
        [InlineData(new int[] { 1000, 0 }, 0)]
        public void CheckLeastCommonMultiple(int[] values, long expectedResult)
        {
            var actualResult = sut.LeastCommonMultiple(values);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(2015, 3, 1)]
        [InlineData(239, 1000, 161)]
        [InlineData(2816213588, 239, 151)]
        [InlineData(9999999999999, 2, 0)]
        public void CheckFibonacciModulus(long n, long modulus, long expectedResult)
        {
            var actualResult = sut.FibonacciModulus(n, modulus);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(3, 4)]
        [InlineData(15, 6)]
        [InlineData(12, 6)]
        [InlineData(100, 5)]
        [InlineData(832564823476, 3)]
        [InlineData(239, 0)]
        [InlineData(614162383528, 9)]
        public void CheckLastDigitOfFibonacciSum(long n, long expectedResult)
        {
            var actualResult = sut.LastDigitOfFibonacciSum(n);
            Assert.Equal(expectedResult, actualResult);
        }
        [Theory]
        [InlineData(3,7,1)]
        [InlineData(10,10,5)]
        [InlineData(10, 200, 2)]
        public void CheckLastDigitOfFibonacciPartialSum(long n, long m, long expectedResult)
        {
            var actualResult = sut.LastDigitOfFibonacciPartialSum(n,m);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(7, 3)]
        [InlineData(5, 0)]
        [InlineData(73, 1)]
       [InlineData(1234567890, 0)]
        public void CheckLastDigitOfFibonacciSquareSum(long n, long expectedResult)
        {
            var actualResult = sut.LastDigitOfFibonacciSquareSum(n);
            Assert.Equal(expectedResult, actualResult);
        }
        

    }
}
