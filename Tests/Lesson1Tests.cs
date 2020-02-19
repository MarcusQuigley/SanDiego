using Chap1.AlgorithmicToolbox;
using System;
using Xunit;

namespace Chap1.AlgorithmicToolbox.Tests
{
    public class Week1Tests : IDisposable
    {
        Week1 lesson1;
        Random rand;
        public Week1Tests()
        {
            lesson1 = new Week1();
            rand = new Random();
        }

        public void Dispose() { }

        [Theory]
        //[InlineData(10,0, 10)]
        [InlineData(2147483647, 13, 2147483660)]
        public void SumDigitsTest(int value1, int value2, long expectedResult)
        {
            var actualResult = lesson1.SumDigits(value1,   value2);
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 2, 4, 7, 3, 9 }, 63)]
        [InlineData(new int[] { 100000, 90000 }, 9000000000)]
        public void MaximumPairProductTests(int[] input, long expectedResult)
        {
             var actualResult = lesson1.MaximumPairProduct(input);
            Assert.Equal(expectedResult, actualResult);
         }

        [Theory]
        [InlineData(new int[] { 2, 4, 7, 3, 9 }, 63)]
        [InlineData(new int[] { 100000, 90000,4 }, 9000000000)]
        public void MaximumPairProductNaiveTests(int[] input, long expectedResult)
        {
            var actualResult = lesson1.MaximumPairProductNaive(input);
            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [InlineData(10, 100000)]
        [InlineData(5, 100)]
        public void MaxPairStressTest(int maxArraySize, int maxValue)
        {
            var actualResult = lesson1.StressTest(maxArraySize, maxValue);
            Assert.True(actualResult);
        }
    }
}
