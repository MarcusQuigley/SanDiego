using Chap1.AlgorithmicToolbox.Exercises;
using Chap1.AlgorithmicToolbox.Workspace;
using System;

namespace WorkspaceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestWeek4SelectionSort();
            TestMajority();
            Console.ReadKey();
        }

        private static void TestWeek4SelectionSort()
        {
            int[] array = new int[ ] { 4, 8, 1, 2, 33, 98, 123, 2, 5, 111, 22, 6 };
            Console.WriteLine("unsorted");
            Week4.DisplayArray<int>(array);
            array = new Week4().SelectionSort(array);
            Console.WriteLine("Sorted");
            Week4.DisplayArray<int>(array);
        }

        static void TestMajority()
        {
            int[] array = new int[] { 1,1,3 };
            var ww = new Week4Exercises();
            Console.WriteLine($"has majority? {ww.MajorityElement(array, 0, array.Length)}");
        }
        static void TestWeek4MergeSort()
        {
            int[] array = new int[] { 7, 3, 5, 2 };//, 33, 98, 123, 2, 5, 111, 22, 6 };
            TestSortAction(array, new Week4().MergeSort);
        }

        static void TestSortAction(int[] array, Func<int[],int[]> func)
        {
            Console.WriteLine("unsorted");
            Week4.DisplayArray<int>(array);
            var result = func(array);
            Console.WriteLine();
            Console.WriteLine("Sorted");
            Week4.DisplayArray<int>(result);
        }
    }
}
