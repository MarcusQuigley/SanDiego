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


    }    
}
