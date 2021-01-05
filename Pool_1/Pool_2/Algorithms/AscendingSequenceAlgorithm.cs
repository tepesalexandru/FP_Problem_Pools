using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class AscendingSequenceAlgorithm : Algorithm
    {
        int n, x, prev;
        bool ascending;
        public override void Compute()
        {
            ascending = true;
            prev = Helper.ReadInt("x_0");
            for (int i = 1; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x < prev)
                {
                    ascending = false;
                }
                prev = x;

            }
        }

        public override void DisplayAnswer()
        {
            if (ascending)
            {
                Console.WriteLine("Answer: the sequence is ascending.");
            } else
            {
                Console.WriteLine("Answer: the sequence is not ascending.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
