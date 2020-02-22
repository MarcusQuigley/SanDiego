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
        [InlineData(50, new int[] { 60,100,120}, new int[] { 20, 50, 30 }, 180.0000)]
      //  [InlineData(10, new int[] { 500 }, new int[] { 30 }, 166.6667)]
        public void CheckMaxLootValue( int capacity, int[] values, int[] weights, float expected)
        {
            var actual = sut.MaxLootValue(capacity,values, weights);
            Assert.Equal(expected, actual);
        }

        //
    }
}
