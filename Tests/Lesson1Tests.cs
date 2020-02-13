using Chap1.AlgorithmicToolbox;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class Lesson1Tests : IDisposable
    {


        public Lesson1Tests()
        {

        }

        public void Dispose()
        {
         }

        [Theory]
        [InlineData(new int[] { 2,4,7,3,9},63)]
        [InlineData(new int[] { 100000, 90000 }, 410065408)]
        public void MaximumPairProductTests(int[] input, int expectedResult)
        {
            Lesson1 l1 = new Lesson1();
            var actualResult = l1.MaximumPairProduct(input);
            Assert.Equal(expectedResult, actualResult);

        }
    }
}
