using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Workspace
{
    public class QuickSortIndexZero
    {
        public int[] Start(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
            return array;
        }

        public void QuickSort(int[] array, int left, int right)
        {
            int index = Partition(array, left, right);
            if (left < index - 1)
                QuickSort(array, left, index - 1);
            if (right > index)
                QuickSort(array, index, right);
        }

        int Partition(int[] array, int left, int right)
        {
            int pivotIndex = (right + left) / 2;
            int pivot = array[pivotIndex];
            var initLeft = left;
            Swap(array, initLeft, pivotIndex);
            left += 1;

            while (left <= right)
            {
                while (array[left] < array[initLeft])
                    left++;
                while (array[right] > array[initLeft])
                    right--;
                Swap(array, left, right);
                left++;
                right--;
            }
            Swap(array, pivotIndex, initLeft);
            DisplayArray(array, pivotIndex);
            return left;
        }

        void Swap(int[] array, int left, int right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }

        void DisplayArray(int[] array, int pivotIndex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < array.Length; i++)
            {
                if (pivotIndex == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{array[i]} ");
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                    Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
