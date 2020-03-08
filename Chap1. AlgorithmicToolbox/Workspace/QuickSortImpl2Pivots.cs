using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Workspace
{
   public class QuickSortImpl2Pivots
    {
        public int[] Start(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
            return array;
        }

        void QuickSort(int[] array, int start, int end)
        {
            int index = Partition(array, start, end);
            if ( index - 1> start)
                QuickSort(array, start, index - 1);
            if (end > index)
                QuickSort(array, index, end);
        }

        int Partition(int[] array, int start, int end)
        {
            int pivotStartIndex = (end + start) / 2;
            int pivot = array[pivotStartIndex];
            int pivotEndIndex = pivotStartIndex;
            while (start <= end)
            {
                while (array[start] < pivot)
                    start++;
                while (array[end] > pivot)
                    end--;
                while (array[start] == pivot)
                {
                    while (start < pivotStartIndex)
                        Swap(array, array[start], array[start + 1]);
                    pivotStartIndex--;
                }
                while (array[end] == pivot)
                {
                    while (end > pivotEndIndex)
                        Swap(array, array[end], array[end - 1]);
                    pivotEndIndex++;
                }
                Swap(array, start, end);
                start++;
                end--;
            }
            return start;
        }

        private static void Swap(int[] array, int start, int end)
        {
            int temp = array[start];
            array[start] = array[end];
            array[end] = temp;
        }
    }
}
