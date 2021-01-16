using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class InsertValueAlgorithm : Algorithm
    {
        int n, e, k;
        int[] arr;
        public override void Compute()
        {
            int i;
            for (i = n; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[k] = e;
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            e = Helper.ReadInt("e");
            k = Helper.ReadInt("k");
            arr = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Helper.ReadInt($"arr[{i}]");
            }
        }
    }
}
