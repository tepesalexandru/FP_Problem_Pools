using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class SumAndProductAlgorithm : Algorithm
    {
        int n, sum, prod;
        public override void Compute()
        {
            sum = 0; prod = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                prod *= i;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: the sum is {sum}, the product is {prod}.");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
