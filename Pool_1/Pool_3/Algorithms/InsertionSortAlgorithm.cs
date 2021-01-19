using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class InsertionSortAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        public override void Compute()
        {
            int i, j, key;
            for (i = 1; i < n; i++)
            {
                key = arr[i];
                j = i - 1;
                while (j >= 0 && arr[j] >= key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine("Answer:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
