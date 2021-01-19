using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class MoveZerosAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        public override void Compute()
        {
            int nextZero = n - 1;
            while (arr[nextZero] == 0) nextZero--;
            int i;
            for (i = 0; i <= nextZero; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = arr[nextZero];
                    arr[nextZero] = 0;
                    nextZero--;
                }
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
