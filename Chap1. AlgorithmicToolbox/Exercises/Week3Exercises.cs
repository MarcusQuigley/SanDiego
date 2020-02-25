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
                while (coins[i] <= weight)
                {
                    weight -= coins[i];
                    answer += 1;
                }
            }
            return answer;
        }

        public double MaxLootValue(int capacity, int[] values, int[] weights)
        {
            int itemsLength = values.Length;
            double result = 0D;
            Item[] itemValues = new Item[itemsLength];
            for (int i = 0; i < itemsLength; i++)
            {
                itemValues[i] = new Item { Weight = weights[i], Value = values[i] };
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
                        var fraction = ((double)capacity / item.Weight);
                        result += fraction * item.Value;
                        //   result += item.Value * ((double)capacity / item.Weight);
                        //   capacity -= result; = (int)( capacity- (fraction * item.Weight));
                    }
                    break;
                }
            }
            return Math.Round(result, 4);
        }

        public double MaxLootValue2(int capacity, int[] values, int[] weights)
        {
            var n = values.Length;
            var items = new Item[n];
            for (var i = 0; i < n; ++i)
            {
                items[i] = new Item { Value = values[i], Weight = weights[i] };
            }

            items = items
                .OrderByDescending(v => v.Cost)
                .ToArray();

            var token = 0;
            var result = 0D;
            while (capacity > 0 && token < items.Length)
            {
                var item = items[token];
                if (item.Weight <= capacity)
                {
                    result += item.Value;
                    capacity -= item.Weight;
                    ++token;
                    continue;
                }

                result += item.Value * ((double)capacity / item.Weight);
                break;
            }

            // return totalValue;
            return Math.Round(result, 4);
        }
               
        public int ComputeMinRefills(int journey, int tank, int[] stops)
        {
            int numRefills = 0;
            int currentRefill = 0;
            int lastRefill = 0;
            int n = stops.Length;
            int[] allStops = new int[n + 2];
            for (int i = 1; i <= n; i++)
            {
                allStops[i] = stops[i - 1];
            }
            allStops[allStops.Length - 1] = journey;

            while (currentRefill <= n)
            {
                lastRefill = currentRefill;
                while (currentRefill <= n && allStops[currentRefill + 1] - allStops[lastRefill] <= tank)
                {
                    currentRefill += 1;
                }
                if (currentRefill == lastRefill)
                {
                    return -1;
                }
                if (currentRefill <= n)
                {
                    numRefills += 1;
                }
            }
            return numRefills;
        }



        public class Item
        {
            public int Weight { get; set; }
            public int Value { get; set; }
            public double Cost => (double)Value / Weight;
            public override string ToString()
            {
                return $"C: {Cost} V: {Value} W: {Weight}";
            }
        }

        public class MaxLootComparer : IComparer<Item>
        {
            public int Compare(Item x, Item y)
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
}
