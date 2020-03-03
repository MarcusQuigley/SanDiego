using System;
using System.Collections.Generic;
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
             
            var  answer = MaxPrizes(n);
            Console.WriteLine(answer.Length);
            foreach (var a in answer)
            {
                Console.Write($"{a} " );
            }
        }

        static long[] MaxPrizes(int n)
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
