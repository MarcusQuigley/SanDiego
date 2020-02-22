using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    public class Week3Exercises
    {

        public int GetChange(int weight)
        {
            int answer = 0;
            int[] coins = { 10, 5, 1 };
            for (int i = 0; i < coins.Length; i++)
            {
                while(coins[i] <= weight)
                {
                    weight -= coins[i];
                    answer += 1;
                }
            }
            return answer;
        }

        public int MaxLootValue(int capacity, int[] values,int[] weights )
        {
            int amount = 0;
            int numItems = values.Length;
            int newCapacity = capacity;
       
            int[][] weightScores = new int[numItems+1][];
            for (int i = 1; i <= numItems; i++)
            {
                weightScores[i] = new int[capacity+1];
                for (int j = 0; j < capacity; j++)
                {
                    if (weights[i-1] <= j)
                    {
                        var remainingItem = j - weights[i-1];
                        weightScores[i][j] = Math.Max(
                            weightScores[i - 1][j],
                            weightScores[i - 1][remainingItem] + values[i - 1]);
                    }
                    else
                    {
                        weightScores[i][j] = values[i - 1];//[j];
                    }
                }
            }
 //V 60 W 20
 //  100  50

            return amount;
        }
    }

    public class MimimumComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            return y;
        }
    }
}
