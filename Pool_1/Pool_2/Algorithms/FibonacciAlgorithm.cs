using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class FibonacciAlgorithm : Algorithm
    {
        int n, fib0, fib1, fibNext;
        public override void Compute()
        {
            fib0 = 0; fib1 = 1;
            for (int i = 2; i <= n; i++)
            {
                fibNext = fib0 + fib1;
                fib0 = fib1;
                fib1 = fibNext;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"The nth fibonacci number is {fibNext}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
