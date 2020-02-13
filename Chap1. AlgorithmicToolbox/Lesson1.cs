using System;

namespace Chap1.AlgorithmicToolbox
{
    public class Lesson1
    {
        public long MaximumPairProduct(int[] input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            int max1 = int.MinValue;
            int max2 = int.MinValue;

            for (int i = 0; i < input.Length; i++)
            {
                if (max1 < input[i])
                {
                    max1 = input[i];
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != max1)
                {
                    if (max2 < input[i])
                    {
                        max2 = input[i];
                    }
                }
            }

            var result = (max1 * max2);
            return result;
        }
    }
}
