using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    public class Week4Exercises
    {
        public int BinarySearch(int[] array, int searchKey)
        {
            if (array.Length == 0)
                return -1;
            if (array.Length == 1)
                return (array[0] == searchKey) ? 0 : -1;

            int low = 0;
            int high = array.Length - 1;

            while (high > low)
            {
                var mid = low + ((high - low) / 2);
                var midResult = array[mid];
                if (midResult == searchKey)
                    return mid;
                if (searchKey < midResult)
                    high = mid - 1;
                else
                    low = mid + 1;
            }
            return -1;
        }
    }
}
