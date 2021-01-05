using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class EqualToPosAlgorithm : Algorithm
    {
        int n, x, nrEqual;
        public override void Compute()
        {
            nrEqual = 0;
            for (int i = 0; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x == i)
                {
                    nrEqual++;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {nrEqual} numbers were equal to their position.");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
