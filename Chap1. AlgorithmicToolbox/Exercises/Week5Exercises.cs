using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
   public class Week5Exercises
    {
        public int MoneyChange(int money, int[] coins)
        {
            int[] minCoins = new int[money+1];
            minCoins[0] = 0;

            for (int m = 1; m <= money; m++)
            {
                minCoins[m] = int.MaxValue;
                for (int i = 0; i < coins.Length; i++)
                {
                    if (coins[i] > m)
                        break;
                    var numCoins = minCoins[m - coins[i]] + 1;
                    if (numCoins < minCoins[m])
                        minCoins[m] = numCoins;
                }
            }
            return minCoins[money];
        }

        public int MoneyChange(int money)
        {
            return MoneyChange(money, new int[] { 1, 3, 4 });
        }

        public (int Count, int[] ResultList) PrimitiveCalculator(int number)
        {
            var operations = Min_operations(number);
            var operationsSequence = Operations_list(number, operations);

            return (Count: operationsSequence.Count()-1, ResultList: operationsSequence);
        }

        private int[] Min_operations(int number)
        {
             int[] operations = new int[number+1] ;
            for (int i = 0; i < 2; i++)
            {
                operations[i] = 0;
            }

            for (int i = 2; i < number + 1; i++)
            {
                var onePlus = operations[i - 1];
                var threeTimes = int.MaxValue;
                var twoTimes = int.MaxValue;
                if (i % 3 == 0)
                {
                    threeTimes = operations[(int)i / 3];
                }
                if (i % 2 == 0)
                {
                    twoTimes = operations[(int)i / 2];
                }
                var op = Min(onePlus, twoTimes, threeTimes);
                operations[i] = op + 1;
            }
            return operations;

        }

        private int[] Operations_list(int number, int[] operations)
        {
            if (number == 1)
                return new int[] { 1 };
            int n = number;
            List<int> results = new List<int>();
            while (n > 0)
            {
                results.Add(n);
                if (n % 3 > 0 && n % 2 > 0)
                    n = n - 1;
                else if (n % 3 == 0 && n % 2 == 0) 
                    n = (operations[n / 3] < operations[n - 1]) ? n / 3 : n - 1;
                else if (n % 3 == 0)
                    n = (operations[n / 3] < operations[n - 1]) ? n / 3 : n - 1;
                else
                    n = (operations[n / 2] < operations[n - 1]) ? n / 2 : n - 1;

            }
            results.Reverse();
            return results.ToArray();
        }

        private int Min(int val1, int val2, int val3)
        {
            var valA = Math.Min(val1, val2);
            return Math.Min(valA, val3);
        }
    }
}
