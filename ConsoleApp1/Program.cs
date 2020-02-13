using Chap1.AlgorithmicToolbox;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLesson1();
            Console.ReadLine();
        }

        static void TestLesson1()
        {
            Lesson1 lesson = new Lesson1();
            if (lesson.StressTest(25, 1000000))
            {
                Console.WriteLine("Stress test passed!!");
            }
        }
    }
}
