using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Workspace
{
    public class Week4
    {
        public int[] SomeSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public int[] SelectionSort(int[] array)
        {
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
            return array;
        }

       public int[] MergeSort(int[] array)
        {
            int[] helper = new int[array.Length];
            MergeSort(array, helper, 0, array.Length - 1);
            return array;
        }

        void MergeSort(int[] array, int[] helper, int start, int end)
        {
            if (start < end)
            {
                var mid = (start + end) / 2;
                MergeSort(array, helper, start, mid);
                MergeSort(array, helper, mid + 1, end);
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
            
            while (helperLeft<=mid && helperRight<=end)
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


        public static void DisplayArray<T>(T[] array, bool oneLine)
        {
            for (int i = 0; i < array.Length; i++)
            {
                var toDisplay = $"{array[i]} ";
                if (oneLine)
                    Console.Write(toDisplay);
                else
                    Console.WriteLine(toDisplay);
            }
        }

        public static void DisplayArray<T>(T[] array)
        {
            DisplayArray(array, true);
        }


       
    }
}
