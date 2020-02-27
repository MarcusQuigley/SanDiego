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
            Array.Sort(segments, new SegmentComparer());

            while (index <= n)
            {
                startIndex = index;
                int startPoint = segments[startIndex].End;
                while (index < n && segments[index].ContainsPoint(startPoint))// segments[index] != segments[startIndex]) //need to see if startIndex segment touchs all new segments
                {
                    index += 1;
                    //need to get the highest value thats touching the segments
                }
                //  if (index > n) throw new Exception();
                if (index <= n)
                {
                    points.Add(startPoint); //need to add this highest value
                                            //      index += 1;
                    if (index == n)
                        break;
                }
            }
            return points.ToArray();
        }

        public int[] CollectingSignatures2(Segment[] segments)
        {
            if (segments == null || segments.Length == 0)
                return new int[] { 0 };
            if (segments.Length == 1)
                return new int[] { segments[0].End };

            int index = 0;
            int startIndex = 0;
            int n = segments.Length;
            List<int> points = new List<int>();
            Array.Sort(segments, new SegmentComparer());

            while (index <= n)
            {
                startIndex = index;
                var set1 = segments[startIndex];
                var jj = startIndex + 1;
                var matches = Enumerable.Empty<int>();
                var matchesCopy = Enumerable.Empty<int>();
                while (jj < n) //when this is false then we need to exit entire while loops.. maybe it shouldnt be here
                {
                    var set2 = segments[jj];
                    if (matches.Any())
                    {
                        matchesCopy = matches;
                        matches = set2.Intersects(matches);
                    }
                    else
                        matches = set2.Intersects(set1);

                    if (jj+1==n) //this is last segment
                    {
                        if (matches.Any())
                            points.Add(matchesCopy.Last());
                        else
                            if (matchesCopy.Any())
                            points.Add(matchesCopy.Last());
                        else
                            //Do i add the last set ?
                            Debug.Write("--");
                        
                        return points.ToArray();
                    }

                    if (matches.Any()) //TODO need to check if its the last segment
                    {
                        jj += 1;
                    }
                    else
                    {
                        index = jj; //

                        if (matchesCopy.Any())
                            points.Add(matchesCopy.Last());
                        else 
                            points.Add(set1.End);
                         
                        break; //back to outer while
                    }

                }

            }

            return points.ToArray();
        }
    }
}
