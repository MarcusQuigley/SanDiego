using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
   public class Week4Exercises
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
    }
}
