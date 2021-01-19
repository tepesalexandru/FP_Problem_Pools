using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class InverseSumAlgorithm : Algorithm
    {
        int n, x, sum;
        public override void Compute()
        {
            int inverse;
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                inverse = 0;
                x = Helper.ReadInt($"x_{i}");
                while (x != 0)
                {
                    inverse *= 10;
                    inverse = inverse + x % 10;
                    x /= 10;
                }
                sum += inverse;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {sum}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
