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
        [InlineData(2, 2)]
        [InlineData(34, 9)]
        public void CheckMoneyChange(int money, int expected)
        {
            var actual = sut.MoneyChange(money);
            Assert.Equal(expected, actual);
        }

        
    }
}
