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
            var money = int.Parse(Console.ReadLine());
//            var arrayItems = Console.ReadLine()
//                                    .Split(' ')
////                                    .Select(i => int.Parse(i))
//                                    .ToArray();
 
            var answer = MoneyChange(money);
            Console.WriteLine(answer);
            //foreach (var a in answer)
            //{
            //    Console.Write($"{a} ");
            //}
        }

        static int MoneyChange(int money, int[] coins)
        {
            int[] minCoins = new int[money + 1];
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

        static int MoneyChange(int money)
        {
            return MoneyChange(money, new int[] { 1, 3, 4 });
        }
    }
}
