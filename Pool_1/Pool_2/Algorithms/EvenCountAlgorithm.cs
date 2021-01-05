using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class EvenCountAlgorithm : Algorithm
    {
        int n, x, nrPare;
        public override void Compute()
        {
            nrPare = 0;
            for (int i = 0; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x % 2 == 0)
                {
                    nrPare++;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {nrPare} even numbers.");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            
        }
    }
}
