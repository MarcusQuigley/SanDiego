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
                int half = start + (end - start) / 2;
                MergeSort(array, helper, start, half);
                MergeSort(array, helper, half + 1, end);
                Merge(array, helper, start, half, end);
            }
        }

        void Merge(int[] array, int[] helper, int low, int middle, int high)
        {
            for (int i = low; i <= high; i++)
            {
                helper[i] = array[i];
            }
            int helperLeft = low;
            int helperRight = middle + 1;
            int current = low;

            while (helperLeft <= middle && helperRight <= high)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft += 1;
                }
                else
                {
                    array[current] = helper[helperRight];
                    helperRight += 1;
                }
                current += 1;
            }
            int remaining = middle - helperLeft;
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


        //void Merge(int[] nums, int[] helper, int low, int mid, int high)
        //{
        //    for (int i = low; i <= high; i++)
        //    {
        //        helper[i] = nums[i];
        //    }
        //    int helperLeft = low;
        //    int helperRight = mid + 1;
        //    int cur = low;
        //    // iterate through helper array. Compare the left and right half,
        //    // copying back the smaller element from the two halves into the
        //    // original array.
        //    while (helperLeft <= mid && helperRight <= high)
        //    {
        //        if (helper[helperLeft] <= helper[helperRight])
        //        {
        //            nums[cur] = helper[helperLeft];
        //            helperLeft++;
        //        }
        //        else
        //        {
        //            nums[cur] = helper[helperRight];
        //            helperRight++;
        //        }
        //        cur++;
        //    }
        //    // copy the rest of the left side of the array into the target array.
        //    // The right side doesn't need to be copied because it's already there.
        //    int remaining = mid - helperLeft;
        //    for (int i = 0; i <= remaining; i++)
        //    {
        //        nums[cur + i] = helper[helperLeft + i];
        //    }
        //}

    }
}
