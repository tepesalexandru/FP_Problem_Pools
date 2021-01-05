using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class MaxEqualSequenceAlgorithm : Algorithm
    {
        int n, x, prev, maxEquals;
        public override void Compute()
        {
            prev = Helper.ReadInt("x_0");
            maxEquals = 1;
            for (int i = 1; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x == prev)
                {
                    maxEquals++;
                } else
                {
                    maxEquals = 1;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: the maximum number of equal items is {maxEquals}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
