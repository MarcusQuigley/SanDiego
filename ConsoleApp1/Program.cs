using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitOfFibonacciSquareSum(n));
        }

        static int LastDigitOfFibonacciSquareSum(long n)
        {
            int modulus = 10;
            var pisanoValues = GetPisanoValues(modulus);
            var pisanoPeriod = pisanoValues.Length;

            //sq of fib n = fib n * fib n+1

            var nFib = n % pisanoPeriod;
            var mFib = (n + 1) % pisanoPeriod;
            var nFib1 = pisanoValues[nFib];
            var mFib1 = pisanoValues[mFib];

            return (nFib1 * mFib1) % 10;
        }

        static int[] GetPisanoValues(int modulus)
        {
            int previous = 0;
            int current = 1;
            int next = 0;
            List<int> values = new List<int> { 0 };
            for (int i = 0; i < modulus * modulus; i++)
            {
                values.Add(current);
                next = (previous + current) % modulus;
                previous = current;
                current = next;
                if (previous == 1 && current == 0)
                {
                    break;
                }
            }
            return values.ToArray();
        }
    }
}
