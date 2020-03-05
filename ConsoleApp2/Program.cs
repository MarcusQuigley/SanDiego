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
            var length = Console.ReadLine();
            var args1 = Console.ReadLine()
                                    .Split(' ')
                                    .Select(y => int.Parse(y))
                                    .ToArray();

            var result = MajorityElement(args1, 0, args1.Length); 

            Console.WriteLine(result==-1? 0:1);

            //var answer = BinarySearch(arrayItems);
            //Console.WriteLine(answer);
            //foreach (var a in answer)
            //{
            //    Console.Write($"{a} ");
            //}
        }

        static int MajorityElement(int[] array, int left, int right)
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

        static int CountElements(int[] array, int start, int end, int element)
        {
            int total = 0;
            for (int i = start; i < end; i++)
            {
                if (array[i] == element)
                    total += 1;
            }
            return total;
        }
    }
}
