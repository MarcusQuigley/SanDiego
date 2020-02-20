using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Chap1.AlgorithmicToolbox.Exercises
{
    public class Week3Exercises
    {
        //public int GetChangeOld(int weight)
        //{
        //    int[] items = new int[] { 10, 5, 1 };
        //    List<int> answers = new List<int>();
        //    int item = 0;
        //    while (weight > 0)
        //    {
        //        for (int j = 0; j < items.Length; j++)
        //        {
        //            if (items[j] < weight)
        //            {
        //                item = items[j];
        //                break;
        //            }
        //        }
        //        answers.Add(item);
        //        weight -= item;
        //    }
        //    return answers.Count;
        //}

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
