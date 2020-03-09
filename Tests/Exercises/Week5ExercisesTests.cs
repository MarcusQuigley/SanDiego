using Chap1.AlgorithmicToolbox.Exercises;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Chap1.AlgorithmicToolbox.Tests.Exercises
{
    public class Week5ExercisesTests
    {
        Week5Exercises sut;
        public Week5ExercisesTests()
        {
            sut = new Week5Exercises();
        }

        [Theory]
     //   [InlineData(2, 2)]
        [InlineData(11, 3)]
        public void CheckMoneyChange(int money, int expected)
        {
            var actual = sut.MoneyChange(money,new int[] { 1,2,5});
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(10, new int[] {1, 3, 9, 10})]
        [InlineData(5, new int[] { 1, 2, 4, 5 })]
        public void CheckPrimitiveCalculator(int money, int[] expected)
        {
            var actual = sut.PrimitiveCalculator(money);
            Assert.Equal(expected, actual);
        }
    }
}
