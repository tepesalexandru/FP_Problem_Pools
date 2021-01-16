using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class FindKAlgorithm : Algorithm
    {
        int n, k, poz;
        int[] arr;
        public override void Compute()
        {
            poz = -1;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == k)
                {
                    poz = i;
                    break;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {poz}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            k = Helper.ReadInt("k");
            arr = Helper.ReadIntArray(n);
        }
    }
}
