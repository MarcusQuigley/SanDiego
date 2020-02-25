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
            var n = int.Parse(Console.ReadLine());
            var profits = Console.ReadLine()
                                     .Split(' ')
                                     .Select(i => int.Parse(i))
                                     .ToArray();
            var clicks = Console.ReadLine()
                                     .Split(' ')
                                     .Select(i => int.Parse(i))
                                     .ToArray();

            Console.WriteLine(MaxAdRevenue(profits, clicks));
        }

        static   long MaxAdRevenue(int[] profits, int[] clicks)
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

    }
}
