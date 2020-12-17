using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class DivisorAlgorithm : Algorithm
    {
        int n, k;
        bool divides;
        public override void Compute()
        {
            if (n % k == 0)
            {
                divides = true;
            } else
            {
                divides = false;
            }
        }

        public override void DisplayAnswer()
        {
            if (divides)
            {
                Console.WriteLine("Answer: n can be divided by k.");
            } else
            {
                Console.WriteLine("Answer: n cannot be divided by k.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            k = Helper.ReadInt("k");
        }
    }
}
