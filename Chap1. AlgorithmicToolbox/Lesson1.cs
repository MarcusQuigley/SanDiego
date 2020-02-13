using System;

namespace Chap1.AlgorithmicToolbox
{
    public class Lesson1 :ILesson
    {
        public long MaximumPairProduct(int[] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.Length < 2)
            {
                throw new InvalidOperationException("Only 1 entry in array exists. Need two at a minimum!.");
            }

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (max1 < input[i])
                {
                    max1 = input[i];
                }
            }
            for (int j = 0; j < input.Length; j++)
            {
                if (input[j] != max1)
                {
                    if (max2 < input[j])
                    {
                        max2 = input[j];
                    }
                }
            }

            long result = max1 * (long) max2;
            return result;
        }
        public long MaximumPairProductNaive(int[] input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
            long result = long.MinValue;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                     if (input[i] != input[j])
                    {
                        result = Math.Max(result, input[i] * (long) input[j]);
                    }
                }
            }
             return result;
        }

        public bool StressTest(int maxArraySize, int maxValue)
        {
            Random rand = new Random();
            int testCount = 1000;
            int count = 0;
            Lesson1 lesson1 = new Lesson1();
            do
            {
                var arrayLength = rand.Next(2, maxArraySize);
                var array = new int[arrayLength];// Array.CreateInstance(typeof(int), arrayLength);
                for (int i = 1; i < arrayLength; i++)
                {
                    array[i] = rand.Next(0, maxValue);
                }

                var result = lesson1.MaximumPairProduct(array);
                var resultNaive = lesson1.MaximumPairProductNaive(array);
                if (result != resultNaive)
                {
                    Console.WriteLine($"Error with results MaxPair: {result} MaxPairNaive: {resultNaive}");
                    return false;
                }
                 
            }
            while (count++ < testCount);
            return true;
        }
    }
}
