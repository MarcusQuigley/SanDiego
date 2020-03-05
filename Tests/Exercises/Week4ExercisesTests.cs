using Chap1.AlgorithmicToolbox.Exercises;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Chap1.AlgorithmicToolbox.Tests.Exercises
{
    public class Week4ExercisesTests
    {
        Week4Exercises sut;
        public Week4ExercisesTests()
        {
            sut = new Week4Exercises();
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 8, 12, 13 }, new int[] { 8, 1, 23, 1, 11 }, new int[] { 2, 0, -1, 0, -1 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, })]
        public void CheckBinarySearch(int[] array, int[] searchKeys, int[] expected)
        {
            int[] actual = new int[expected.Length];
            for (int i = 0; i < searchKeys.Length; i++)
            {
                actual[i] = sut.BinarySearch(array, searchKeys[i]);
            }
            for (int j = 0; j < actual.Length; j++)
            {
                Assert.Equal(expected[j], actual[j]);
            }
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, 0)]
        [InlineData(new int[] { 2, 3, 9, 2, 2 }, 1)]
        [InlineData(new int[] { 2, 2, 3, 4 }, 0)]
        [InlineData(new int[] { 2, 124554847, 2, 941795895, 2, 2, 2, 2, 792755190, 756617003 }, 1)]
        [InlineData(new int[] { 2, 124554847, 2, 941795895, 2, 2 }, 1)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 0, 0, 0, 0, 1, 2, 3, 4 }, 0)]
        [InlineData(new int[] { 0, 1 }, 0)]
        [InlineData(new int[] { 6, 6 }, 1)]
        public void CheckMajorityElement(int[] array, int expected)
        {
            var actual = sut.MajorityElement(array, 0, array.Length);
            actual = (actual == -1) ? 0 : 1;
            Assert.Equal(expected, actual);
        }
    }
}
