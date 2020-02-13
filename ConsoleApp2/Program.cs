using Chap1.AlgorithmicToolbox;
using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayLength = Console.ReadLine();
            var arrayItems = Console.ReadLine()
                                   .Split(' ')
                                   .Select(i => int.Parse(i))
                                   .ToArray();
            Lesson1 lesson1 = new Lesson1();
            Console.WriteLine($"sum: {lesson1.MaximumPairProduct(arrayItems)}");

        }
 
    }
}
