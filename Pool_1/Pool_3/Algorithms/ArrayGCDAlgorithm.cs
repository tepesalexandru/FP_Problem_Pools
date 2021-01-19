using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class ArrayGCDAlgorithm : Algorithm
    {
        int n, arrGCD;
        int[] arr;
        public override void Compute()
        {
            int GCD(int x, int y)
            {
                return y == 0 ? x : GCD(y, x % y);
            }
            arrGCD = arr[0];
            for (int i = 1; i < n; i++)
            {
                arrGCD = GCD(arrGCD, arr[i]);
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {arrGCD}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
