using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  var arrayLength = Console.ReadLine();
            //var arrayItems = "3 5 77 3"
            //                       .Split(' ')
            //                       .Select(i => int.Parse(i))
            //                       .ToArray();
            var dist = int.Parse(Console.ReadLine());
            var tank = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            int[] stops = new int[n];
            if (n > 0)
            {
                stops = Console.ReadLine()
                                     .Split(' ')
                                     .Select(i => int.Parse(i))
                                     .ToArray();
            }
            
            Console.WriteLine(computeMinRefills(dist, tank, stops));
        }

        static int computeMinRefills(int journey, int tank, int[] stops)
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

    }
}
