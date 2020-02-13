using Chap1.AlgorithmicToolbox;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class Lesson1Tests : IDisposable
    {
        Lesson1 lesson1;
        Random rand;
        public Lesson1Tests()
        {
            lesson1 = new Lesson1();
            rand = new Random();
        }

        public void Dispose()
        {
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
        [InlineData(new int[] { 100000, 90000 }, 9000000000)]
        public void MaximumPairProductNaiveTests(int[] input, long expectedResult)
        {
            var actualResult = lesson1.MaximumPairProductNaive(input);
            Assert.Equal(expectedResult, actualResult);
        }


        [Theory]
        [InlineData(10, 100000)]
        public void MaxPairStressTest(int maxArraySize, int maxValue)
        {
            var actualResult = lesson1.StressTest(maxArraySize, maxValue);
            Assert.True(actualResult);
        }
    }
}
