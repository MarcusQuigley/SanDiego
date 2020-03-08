using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Workspace
{
   public class RandomQS
    {
        public int[] Start(int[] array)
        {
            RandomizedQuickSort(array, 0, array.Length - 1);
            return array;
        }

        private void RandomizedQuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;
            int randomIndex = new Random().Next(right - left + 1) + left;
            Swap(array, left, randomIndex);

            int index = Partition(array, left, right);
            RandomizedQuickSort(array, left, index - 1);
            RandomizedQuickSort(array, index + 1, right);
        }

        private int Partition(int[] array, int left, int right)
        {
            int pivot = array[left];
            int pivotIndex = left;
            for (int i = pivotIndex + 1; i <= right; i++)
            {
                if(array[i] <= pivot) {
                    pivotIndex++;
                    Swap(array, i, pivotIndex);
                }
            }
            Swap(array, left, pivotIndex);
            return pivotIndex;
        } 

        private static void Swap(int[] array, int index1, int index2)
        {
            if (index1 == index2)
            {
                Console.WriteLine("Same index no swap");
                return;
            }
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
