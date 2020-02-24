using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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

        public double MaxLootValue(int capacity, int[] values, int[] weights)
        {
            int itemsLength = (values.Length == weights.Length) ? values.Length : throw new ArgumentException("Must be an equal amouont of values and weights");
            double result = 0;
            ItemValue[] itemValues = new ItemValue[itemsLength];
            for (int i = 0; i < itemsLength; i++)
            {
                itemValues[i] = new ItemValue { Index = i, Weight = weights[i], Value = values[i] };
            }
            Array.Sort(itemValues, new MaxLootComparer());
            for (int j = 0; j < itemsLength; j++)
            {
                var item = itemValues[j];
            
                if (item.Weight <= capacity)
                {
                    capacity -= item.Weight;
                    result += item.Value;
                }
                else
                {
                    if (capacity > 0)
                    {
                        var fraction = ((double) capacity / (double)item.Weight);
                        result +=   fraction * item.Value ;
                        capacity =(int)( capacity- (fraction * item.Weight));
                    }
                    break;
                }
            }
            return Math.Round( result,4);
        }
 
 //       public int MaxLootValue(int capacity, int[] values,int[] weights )
 //       {
 //           int amount = 0;
 //           int numItems = values.Length;
 //           int newCapacity = capacity;

        //           int[]  weightScores = new int[capacity];
        //           for (int i = 1; i <= numItems; i++)
        //           {
        //                for (int j = 0; j < capacity; j++)
        //               {
        //                   if (weights[i-1] <= j)
        //                   {
        //                       var remainingItem = j - weights[i-1];
        //                       weightScores[i][j] = Math.Max(
        //                           weightScores[i - 1][j],
        //                           weightScores[i - 1][remainingItem] + values[i - 1]);
        //                   }
        //                   else
        //                   {
        //                       weightScores[i][j] = values[i - 1];//[j];
        //                   }
        //               }
        //           }
        ////V 60 W 20
        ////  100  50

        //           return amount;
        //       }
    }

    public class ItemValue
    {
        public int Index { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }
        public double Cost => (double)Value / Weight;
        public override string ToString()
        {
            return $"{Index} C: {Cost} V: {Value} W: {Weight}";
        }
    }

    public class MaxLootComparer : IComparer<ItemValue>
    {
        public int Compare(ItemValue x, ItemValue y)
        {
            return y.Cost.CompareTo(x.Cost);
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
