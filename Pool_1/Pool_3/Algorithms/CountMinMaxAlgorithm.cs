using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class CountMinMaxAlgorithm : Algorithm
    {
        int n, min, max, nmin, nmax;
        int[] arr;
        public override void Compute()
        {
            min = arr[0]; max = arr[0];
            nmin = 1; nmax = 1;
            for (int i = 1; i < n; i++)
            {

                if (arr[i] == max)
                {
                    nmax++;
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    nmax = 1;
                }
                if (arr[i] == min)
                {
                    nmin++;
                } else if (arr[i] < min)
                {
                    min = arr[i];
                    nmin = 1;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: The maximum number ({max}) appears {nmax} times. The minimum number ({min}) appears {nmin} times.");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
