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
        [InlineData(2, 2)]
        [InlineData(28, 6)]
        public void CheckGetChange(int weight, int expected)
        {
            var actual = sut.GetChange(weight);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(50, new int[] { 60, 100, 120 }, new int[] { 20, 50, 30 }, 180.0)]
        [InlineData(10, new int[] { 500 }, new int[] { 30 }, 166.6667)]
        public void CheckMaxLootValue(int capacity, int[] values, int[] weights, double expected)
        {
            var actual = sut.MaxLootValue(capacity, values, weights);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(950, 400, new int[] { 200, 375, 550, 750 }, 2)]
        [InlineData(10, 3, new int[] { 1, 2, 5, 9 }, -1)]
        [InlineData(10, 3, new int[] { 1, 2, 5, 7 }, 3)]
        [InlineData(10, 3, new int[] { }, -1)]
        public void CheckComputeMinRefills(int dist, int tank, int[] stops, int expected)
        {
            var actual = sut.ComputeMinRefills(dist, tank, stops);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 23 }, new int[] { 39 }, 897)]
        [InlineData(new int[] { 1, 3, -5 }, new int[] { -2, 4, 1 }, 23)]
        public void CheckMaxAdRevenue(int[] a, int[] b, long expected)
        {
            var actual = sut.MaxAdRevenue(a, b);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 3, 5, 6 }, new int[] { 3 })]
        [InlineData(new int[] { 4, 1, 2, 4 }, new int[] { 7, 3, 5, 6 }, new int[] { 3, 6 })]
        [InlineData(new int[] { 4, 1, 2, 5 }, new int[] { 7, 3, 5, 6 }, new int[] { 3, 6 })]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4 })]
        [InlineData(new int[] { 1, 2, 3, 4, 7, 15, 17 }, new int[] { 6, 5, 15, 16, 19, 20, 21 }, new int[] { 5, 19 })]
        [InlineData(new int[] { 2, 3, 8 }, new int[] { 8, 15, 24 }, new int[] { 8, })]
        public void CheckCollectingSignatures(int[] a, int[] b, int[] expected)
        {
            Segment[] segments = new Segment[a.Length];
            for (int i = 0; i < segments.Length; i++)
            {
                segments[i] = new Segment(a[i], b[i]);
            }
            var actual = sut.CollectingSignatures(segments);
            Assert.Equal(expected.Length, actual.Length);
            Array.Sort(actual);
            for (int j = 0; j < actual.Length; j++)
            {
                Assert.Equal(expected[j], actual[j]);
            }
        }

        [Theory]

        [InlineData(6, 3)]
        [InlineData(8, 3)]
        [InlineData(2, 1)]
        [InlineData(55, 10)]
        public void CheckMaxPrizes(int a, int expected)
        {
            var actual = sut.MaxPrizes(a);
            Assert.Equal(expected, actual.Length);
        }
     }
}
