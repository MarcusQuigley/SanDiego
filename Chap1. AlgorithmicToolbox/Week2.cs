using System;
using System.Collections.Generic;
using System.Text;

namespace Chap1.AlgorithmicToolbox
{
    class Week2<T> : ILesson
    {

        public int Fibonacci(int n)
        {
            int n0 = 0;
            int n1 = 1;
            int result=0;
            if (n == 0) return n0;
            if (n == 1) return n1;
            for (int i = 2; i < n; i++)
            {
                result = n0 + n1;
                n0 = n1;
                n1 = result;
            }
            return result;
        }

        public bool StressTest(int maxArraySize, int maxValue)
        {
            throw new NotImplementedException();
        }
    }
}
