using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class FindNumberAlgorithm : Algorithm
    {
        int n, x, a, poz = -1;
        public override void Compute()
        {
            for (int i = 0; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x == a)
                {
                    poz = i;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {a} is found on position {poz}.");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            a = Helper.ReadInt("a");
        }
    }
}
