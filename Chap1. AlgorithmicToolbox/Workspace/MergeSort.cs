using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    class MergeSort
    {
        public int[] Sort(int[] array)
        {
            int[] helper = new int[array.Length];
            Sort(array, helper, 0, array.Length - 1);
            return array;
        }

        void Sort(int[] array, int[] helper, int start, int end)
        {
            if (start < end)
            {
                var mid = (start + end) / 2;
                Sort(array, helper, start, mid);
                Sort(array, helper, mid + 1, end);
                Merge(array, helper, start, mid, end);
            }
        }

        void Merge(int[] array, int[] helper, int start, int mid, int end)
        {
            for (int i = start; i <= end; i++)
            {
                helper[i] = array[i];
            }

            int helperLeft = start;
            int helperRight = mid + 1;
            int current = start;

            while (helperLeft <= mid && helperRight <= end)
            {
                if (helper[helperLeft] < helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    array[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }
            int remaining = mid - helperLeft;
            for (int i = 0; i <= remaining; i++)
            {
                array[current + i] = helper[helperLeft + i];
            }
        }
    }
}
