using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class LexicographicAlgorithm : Algorithm
    {
        int n, m;
        int[] arr1, arr2;
        bool isFirst;
        public override void Compute()
        {
            isFirst = true;
            int i = 0;

            while (i < n && i < m)
            {
                if (arr1[i] > arr2[i])
                {
                    isFirst = false;
                }
            }

        }

        public override void DisplayAnswer()
        {
            if (isFirst)
            {
                Console.WriteLine($"Answer: the first array comes before the second array in lexicographic order.");
            } else
            {
                Console.WriteLine($"Answer: the second array comes before the first array in lexicographic order.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr1 = Helper.ReadIntArray(n);
            m = Helper.ReadInt("m");
            arr2 = Helper.ReadIntArray(m);
        }
    }
}
