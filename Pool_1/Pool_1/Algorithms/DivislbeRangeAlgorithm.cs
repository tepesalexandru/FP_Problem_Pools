using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class DivislbeRangeAlgorithm : Algorithm
    {
        int a, b, n, result;
        public override void Compute()
        {
            result = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0) result++;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {result} numbers");
        }

        public override void ReadInput()
        {
            a = Helper.ReadInt("a");
            b = Helper.ReadInt("b");
            n = Helper.ReadInt("n");
        }
    }
}
