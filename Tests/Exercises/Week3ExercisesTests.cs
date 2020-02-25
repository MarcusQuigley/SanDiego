using Chap1.AlgorithmicToolbox.Exercises;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Chap1.AlgorithmicToolbox.Tests.Exercises
{
    public class Week3ExercisesTests
    {
        Week3Exercises sut;
        public Week3ExercisesTests()
        {
            sut = new Week3Exercises();
        }

        [Theory]
        [InlineData(2,2)]
        [InlineData(28, 6)]
        public void CheckGetChange(int weight, int expected)
        {
            var actual = sut.GetChange(weight);
            Assert.Equal(expected, actual);
        }

        [Theory]
         [InlineData(50, new int[] { 60,100,120}, new int[] { 20, 50, 30 }, 180.0)]
         [InlineData(10, new int[] { 500 }, new int[] { 30 }, 166.6667)]
        public void CheckMaxLootValue( int capacity, int[] values, int[] weights, double expected)
        {
            var actual = sut.MaxLootValue(capacity,values, weights);
            Assert.Equal(expected, actual);
        }

        [Theory]
         [InlineData(950, 400, new int[] { 200, 375, 550, 750 } ,2)]
        [InlineData(10,3, new int[] { 1,2,5,9 }, -1)]
        [InlineData(10, 3, new int[] { 1, 2, 5, 7 }, 3)]
        [InlineData(10, 3, new int[] { }, -1)]
        public void CheckComputeMinRefills(int dist, int tank, int[] stops, int expected)
        {
            var actual = sut.ComputeMinRefills(dist, tank, stops);
            Assert.Equal(expected, actual);
        }
    }
}
