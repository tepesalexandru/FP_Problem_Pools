using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class NegativePositiveAlgorithm : Algorithm
    {
        int n, x, neg, zero, poz;
        public override void Compute()
        {
            neg = 0;
            zero = 0;
            poz = 0;
            for (int i = 0; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x < 0)
                {
                    neg++;
                } else if (x > 0)
                {
                    poz++;
                } else
                {
                    zero++;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {neg} negative numbers, {zero} zeros, {poz} positive numbers.");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
