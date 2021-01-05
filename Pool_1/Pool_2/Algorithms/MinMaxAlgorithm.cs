using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class MinMaxAlgorithm : Algorithm
    {
        int n, min, max, x;
        public override void Compute()
        {
            x = Helper.ReadInt("x_0");
            min = x;
            max = 0;
            for (int i = 1; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x > max) max = x;
                if (x < min) min = x;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"The max number is {max}, the min number is {min}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
