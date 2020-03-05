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

            while (high >= low)
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

        public int MajorityElement(int[] array, int left, int right)
        {
            if (left == right)
            {
                return -1;
            }
            if (left + 1 == right)
            {
                return array[left];
            }
            int mid = (left + right - 1) / 2;
            int left_elem = MajorityElement(array, left, mid);
            int right_elem = MajorityElement(array, mid + 1, right);

            int lcount = CountElements(array, left, right, left_elem);
            if (lcount > (right - left) / 2)
                return left_elem;

            int rcount = CountElements(array, left, right, right_elem);
            if (rcount > (right - left) / 2)
                return right_elem;
            return -1;
        }

        int CountElements(int[] array,int start, int end, int element)
        {
            int total=0;
            for (int i = start; i <end; i++)
            {
                if (array[i] == element)
                    total += 1;
            }
            return total;
        }
    }
}
