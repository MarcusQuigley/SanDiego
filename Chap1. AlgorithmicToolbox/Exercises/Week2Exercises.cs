using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
            if (values == null || values.Length!=2) throw new ArgumentException(nameof(values));
            
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

        public long LeastCommonMultipleBruteForce(int [] values)
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
                bValues.Add(b );

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

        public int FibonacciModulus(long n, int mod)
        {
            StringBuilder sb = new StringBuilder();// "01");
            string pattern = string.Empty;
            long current = 1;
            long previous = 0;
            long temp = 0;
          //  int result = -1;

            for (int i = 2; i <= n; i++)
            {
                temp = (current + previous) % mod;
                previous = current;
                current = temp;

                long rem = current % mod;
                Debug.Write(rem);
                sb.Append(rem);
                if (sb.ToString().EndsWith("011"))
                {
                    pattern =  sb.ToString();
                    pattern=  pattern.Replace("011", "");
                   
                    pattern = "01" + pattern;
                    break;
                }
                 
            }
            int remainder = (int) n % (pattern.Length);// pattern.Length;
            return int.Parse(pattern[remainder].ToString());
        }
        private bool PatternFound(string remainders, out string pattern)
        {
            pattern = string.Empty;
            Console.WriteLine($"div Length={remainders.Length}");
            int half = remainders.Length / 2;
            string left = remainders.Substring(0, half);
            if (left == remainders.Substring(half))
            {
                pattern = left;
                return true;
            }
            return false;
        }
    }    
}
