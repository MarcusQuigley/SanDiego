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

        public int[] PrimitiveCalculator(int amount)
        {
            List<int> operations = new List<int>();

            operations.Add(amount);
            while (amount>1)
            {
                if (amount % 3 == 0)
                    amount /= 3;
                else if(amount % 2 ==0)
                     amount /= 2;
                else
                    amount -=1;
                operations.Add(amount);
            }
            var result = operations.ToArray();
                            
            Array.Reverse(result);
            return result;
        }
    }
}
