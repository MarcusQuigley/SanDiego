using Chap1.AlgorithmicToolbox;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLesson1();
          //  Console.ReadLine();
        }

        static void TestLesson1()
        {
            Week1 lesson = new Week1();
            if (lesson.StressTest(5, 10))
            {
                Console.WriteLine("Stress test passed!!");
            }

        
        }
    }
}
