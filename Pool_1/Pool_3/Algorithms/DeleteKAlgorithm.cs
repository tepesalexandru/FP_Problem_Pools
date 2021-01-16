using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class DeleteKAlgorithm : Algorithm
    {
        int n, k;
        int[] arr;
        public override void Compute()
        {
            for (int i = k; k < n; k++)
            {
                arr[i] = arr[i + 1];
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine("Answer:");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            k = Helper.ReadInt("k");
            arr = Helper.ReadIntArray(n);
        }
    }
}
