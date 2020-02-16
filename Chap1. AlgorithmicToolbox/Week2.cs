using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Chap1.AlgorithmicToolbox
{
    public class Week2 : ILesson
    {

        public int Fibonacci(int n)
        {
            int n0 = 0;
            int n1 = 1;
            int result = 0;
            if (n < 2) return n;
            for (int i = 2; i <= n; i++)
            {
                result = n0 + n1;
                n0 = n1;
                n1 = result;
            }
            return result;
        }

        public int FibonacciRecursion(int n)
        {
            var sw = Stopwatch.StartNew();
            var result = FibonacciRecursionInternal(n);
            sw.Stop();
            Console.WriteLine($"Elapsed for Fibobacci = {sw.Elapsed.TotalSeconds}");
            return result;
        }

        int FibonacciRecursionInternal(int n)
        {
            if (n < 2) return n;
            return FibonacciRecursionInternal(n - 1) + FibonacciRecursionInternal(n - 2);
        }

        public int FibonacciRecursionWithDP(int n)
        {
            var sw = Stopwatch.StartNew();
            if (n < 2) return n;
            int[] memo = Enumerable.Repeat(-1, n + 1).ToArray();
            memo[0] = 0;
            memo[1] = 1;
            var result = FibonacciRecursionWithDPInternal(n, memo);
            sw.Stop();
            Console.WriteLine($"Elapsed for Fibobacci with DP = {sw.Elapsed.TotalSeconds}");
            return result;
        }

        int FibonacciRecursionWithDPInternal(int n, int[] memo)
        {
            if (n < 2) return n;

            if (memo[n - 1] == -1)
                memo[n - 1] = FibonacciRecursionWithDPInternal(n - 1, memo);
            if (memo[n - 2] == -1)
                memo[n - 2] = FibonacciRecursionWithDPInternal(n - 2, memo);

            return memo[n - 1] + memo[n - 2];
        }

        public bool StressTest(int maxArraySize, int maxValue)
        {
            return false;
        }
    }
}
