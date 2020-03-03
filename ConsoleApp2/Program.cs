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
            var arrayLength = Console.ReadLine();
            var arrayItems = Console.ReadLine()
                                    .Split(' ')
//                                    .Select(i => int.Parse(i))
                                    .ToArray();
 
            var answer = MaxSalary(arrayItems);
            Console.WriteLine(answer);
            //foreach (var a in answer)
            //{
            //    Console.Write($"{a} ");
            //}
        }

        static string MaxSalary(string[] papers)
        {
            if (papers == null || papers.Length == 0)
                return string.Empty;
            if (papers.Length == 1)
                return papers[0];
            StringBuilder sb = new StringBuilder(papers.Length);
            Array.Sort(papers, new StringAsMultiDigitIntComparer());
            for (int k = 0; k < papers.Length; k++)
            {
                sb.Append(papers[k]);
            }
            return sb.ToString();
        }

        public class StringAsMultiDigitIntComparer : IComparer<string>
        {
            public int Compare(string a, string b)
            {
                var intA = int.Parse($"{a}{b}");
                var intB = int.Parse($"{b}{a}");
                if (intA > intB)
                    return -1;
                else if (intB > intA)
                    return 1;
                return 0;
            }
        }
    }
}
