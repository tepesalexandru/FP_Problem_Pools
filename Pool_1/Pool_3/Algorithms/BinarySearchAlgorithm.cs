using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class BinarySearchAlgorithm : Algorithm
    {
        int n, k, poz;
        int[] arr;
        public override void Compute()
        {
            poz = -1;
            void BinarySearch(int l, int r)
            {
                int m = l + (r - l) / 2;
                if (arr[m] == k)
                {
                    poz = m;
                } else if (arr[m] > k)
                {
                    BinarySearch(l, r - 1);
                } else
                {
                    BinarySearch(l + 1, r);
                }
            }
            BinarySearch(0, n);
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {k} is on position {poz}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            k = Helper.ReadInt("k");
            arr = Helper.ReadIntArray(n);
        }
    }
}
