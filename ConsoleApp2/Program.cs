using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arrayLength = Console.ReadLine();
            var args1 = Console.ReadLine()
                                    .Split(' ')
                                    .Select(y => int.Parse(y))
                                    .ToArray();

            int[] array = new int[args1[0]];
            for (int i = 0; i < args1.Length-1; i++)
            {
                array[i] = args1[i + 1];
            }

            var args2 = Console.ReadLine()
                                   .Split(' ')
                                   .Select(t => int.Parse(t))
                                   .ToArray();

            int[] arraySearchKeys = new int[args2[0]];
            for (int j = 0; j < args2.Length-1; j++)
            {
                arraySearchKeys[j] = args2[j + 1];
            }
            for (int j = 0; j < arraySearchKeys.Length; j++)
            {
                Console.Write($"{ BinarySearch(array,arraySearchKeys[j])} ");
            }
            //var answer = BinarySearch(arrayItems);
            //Console.WriteLine(answer);
            //foreach (var a in answer)
            //{
            //    Console.Write($"{a} ");
            //}
        }

        static int BinarySearch(int[] array, int searchKey)
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
