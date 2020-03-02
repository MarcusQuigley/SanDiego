using System;
using System.Collections.Generic;
using System.Linq;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    public class Week2Exercises
    {
        public int Fibonacci(int n)
        {
            if (n < 2) return n;
            int temp = 0;
            int previous = 0;
            int current = 1;

            for (int i = 2; i <= n; i++)
            {
                temp = previous + current;
                previous = current;
                current = temp;
            }
            return current;
        }

        public int LastDigitOfFibonacci(int n)
        {
            if (n < 2) return n;
            int temp = 0;
            int previousLastDigit = 0;
            int currentLastDigit = 1;
            for (int i = 2; i <= n; i++)
            {
                temp = (previousLastDigit + currentLastDigit) % 10;
                previousLastDigit = currentLastDigit;
                currentLastDigit = temp;
            }
            return currentLastDigit;
        }

        public int GreatestCommonDivisor(int[] values)
        {
            if (values == null || values.Length != 2) throw new ArgumentException(nameof(values));

            int a = values[0];
            int b = values[1];
            int remainder = 0;

            while (true)
            {
                remainder = a % b;
                if (remainder == 0)
                {
                    break;
                }
                a = b;
                b = remainder;
            }
            return b;
        }

        public long LeastCommonMultipleBruteForce(int[] values)
        {
            if (values == null || values.Length != 2) throw new ArgumentException(nameof(values));

            int a = values.Min();
            int b = values.Max();
            int tempa = a;
            int tempb = b;
            if (b % a == 0) return a;

            List<int> aValues = new List<int>();
            List<int> bValues = new List<int>();
            int counter = 1;

            while (true)
            {

                aValues.Add(a);
                bValues.Add(b);

                for (int i = 0; i < aValues.Count; i++)
                {
                    if (b < aValues[i])
                        break;
                    if (b == aValues[i])
                        return b;
                }

                for (int i = 0; i < bValues.Count; i++)
                {
                    if (a < bValues[i])
                        break;
                    if (a == bValues[i])
                        return a;
                }

                counter += 1;
                a = tempa * counter;
                b = tempb * counter;
            }
            // return result;
        }

        public long LeastCommonMultiple(int[] values)
        {
            if (values == null || values.Length != 2) throw new ArgumentException(nameof(values));
            if (values.Any(v => v == 0)) return 0;
            int gcm = GreatestCommonDivisor(values);
            return (values[0] * (long)values[1]) / gcm;
        }

        public long FibonacciModulus(long n, long mod)
        {
            long pisanoPeriod = PisanoPeriod(mod);
            if (pisanoPeriod == -1)
                return -1;
            long remainder = n % pisanoPeriod;
            long current = 1;
            long previous = 0;
            long next = remainder;

            for (int i = 1; i < remainder; i++)
            {
                next = (current + previous) % mod;
                previous = current;
                current = next;
            }
            return next;// % mod;
        }

        private long PisanoPeriod(long mod)
        {
            long previous = 0;
            long current = 1;
            long next = 0;
            for (int i = 0; i < mod * mod; i++)
            {
                next = (previous + current) % mod;
                previous = current;
                current = next;
                if (previous == 0 && current == 1)
                    return i + 1;
            }
            return -1;
        }

        public int LastDigitOfFibonacciSum(long n)
        {
            int modulus = 10;
            var pisanoValues = GetPisanoValues(modulus);
            int pisanoPeriod = pisanoValues.Length;

            //sum of n Fib = fib n +2 -1
            var m = (n + 2) % pisanoPeriod;
            var sum = pisanoValues[m] - 1;
            if (sum < 0)
                sum = 9;

            var lastDigitOfSum = sum % 10;

            return lastDigitOfSum;
        }

        public int LastDigitOfFibonacciPartialSum(long n, long m)
        {
            int modulus = 10;
            var pisanoValues = GetPisanoValues(modulus);
            var pisanoLength = pisanoValues.Length;

            //trick to get sum wihtout summing all 
            long newm = (m + 2) % pisanoLength;
            long newn = (n + 1) % pisanoLength;
            int start = pisanoValues[newn] - 1;
            int end = pisanoValues[newm] - 1;
            if (end < start)
            {
                end += 10;
            }
            return Math.Abs(end - start);// % 10;
        }

        public int LastDigitOfFibonacciSquareSum(long n)
        {
            int modulus = 10;
            var pisanoValues = GetPisanoValues(modulus);
            var pisanoPeriod = pisanoValues.Length;

            //sq of fib n = fib n * fib n+1

            var nFib = n % pisanoPeriod;
            var mFib = (n+1) % pisanoPeriod;
            var nFib1 = pisanoValues[nFib];
            var mFib1 = pisanoValues[mFib];

            return ( nFib1 * mFib1) % 10;
        }

        private int[] GetPisanoValues(int modulus)
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
