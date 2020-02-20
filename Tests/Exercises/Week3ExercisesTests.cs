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
    }
}
