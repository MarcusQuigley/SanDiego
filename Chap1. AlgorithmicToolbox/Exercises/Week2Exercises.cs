using System;
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
    }    
}
