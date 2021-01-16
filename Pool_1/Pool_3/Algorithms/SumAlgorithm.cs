using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class SumAlgorithm : Algorithm
    {
        int n, sum;
        int[] arr;
        public override void Compute()
        {
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: the sum is {sum}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
