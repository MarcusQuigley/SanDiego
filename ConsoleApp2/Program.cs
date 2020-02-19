using Chap1.AlgorithmicToolbox;
using Chap1.AlgorithmicToolbox.Exercises;
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
            //Week1 lesson1 = new Week1();
            //Console.WriteLine($"sum: {lesson1.MaximumPairProduct(arrayItems)}");

            Console.WriteLine();
            TestLastDigitOfFibonacciPartialSum();
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

        static void TestFibonacciMod()
        {
            Week2Exercises week2 = new Week2Exercises();
            Console.WriteLine("Fibonacci mod");
            Console.WriteLine(week2.FibonacciModulus(2015, 3));
            Console.WriteLine(week2.FibonacciModulus(239, 1000));
             Console.WriteLine(week2.FibonacciModulus(2816213588, 239));
            Console.ReadKey();
        }

        static void TestLastDigitOfFibonacciPartialSum()
        {
            Week2Exercises week2 = new Week2Exercises();
            Console.WriteLine("Fibonacci mod");
            Console.WriteLine(week2.LastDigitOfFibonacciPartialSum(5, 10));
        }

    }
}
