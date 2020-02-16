using Chap1.AlgorithmicToolbox;
using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          //  var arrayLength = Console.ReadLine();
            var arrayItems = "3 5 77 3"
                                   .Split(' ')
                                   .Select(i => int.Parse(i))
                                   .ToArray();
            Week1 lesson1 = new Week1();
            Console.WriteLine($"sum: {lesson1.MaximumPairProduct(arrayItems)}");

            Console.WriteLine();
            TestFibonacciTimes();

        }

        static void TestFibonacciTimes()
        {
            Week2 week2 = new Week2();
            Console.WriteLine("Fibonacci");
            week2.FibonacciRecursion(46);
            Console.WriteLine("onto Fib with DP");
            week2.FibonacciRecursionWithDP(46);
            Console.ReadKey();
        }
 
    }
}
