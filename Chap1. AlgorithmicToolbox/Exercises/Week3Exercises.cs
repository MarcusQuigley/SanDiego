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

        public long MaxAdRevenue(int[] profits, int[] clicks)
        {
            long result = 0;
            Array.Sort(profits);
            Array.Sort(clicks);
            for (int i = 0; i < profits.Length; i++)
            {
                var profit = profits[i] * (long)clicks[i];
                result += profit;
            }

            return result;
        }

        public int[] CollectingSignatures(Segment[] segments)
        {
            if (segments == null || segments.Length == 0)
                return new int[] { 0 };
            if (segments.Length == 1)
                return new int[] { segments[0].End };

            int index = 0;
            int startIndex = 0;
            int n = segments.Length;
            List<int> points = new List<int>();
            Array.Sort(segments, new SegmentLeftComparer());
            int lowestEndPoint = -1;
            while (index < n)
            {
                startIndex = index;
                var set1 = segments[startIndex];
                var nextIndex = startIndex + 1;
                lowestEndPoint = set1.End;

                while (nextIndex < n)
                {
                    var set2 = segments[nextIndex];
                    if (Intersects(lowestEndPoint, set2.Start))
                    {
                        if (set2.End < lowestEndPoint)
                        {
                            lowestEndPoint = set2.End;
                        }
                        nextIndex += 1;
                    }
                    else
                    {
                        points.Add(lowestEndPoint);

                        break;
                    }
                }
                if (n == nextIndex)
                {
                    points.Add(lowestEndPoint);
                    break;
                }
                index = nextIndex;
            }
            return points.ToArray();
        }

        bool Intersects(int end, int segmentStart)
        {
            return segmentStart <= end;
        }

        public long[] MaxPrizes(int n)
        {
            int current = 0;
            List<long> results = new List<long>();
            while (n > 0)
            {
                current += 1;
                if (current * 2 >= n)
                {
                    results.Add(n);
                    break;
                }
                n -= current;
                results.Add(current);
            }
            return results.ToArray();
        }
    }
}
