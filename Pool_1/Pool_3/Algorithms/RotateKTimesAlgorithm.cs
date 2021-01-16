using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class RotateKTimesAlgorithm : Algorithm
    {
        int n, k;
        int[] arr;
        public override void Compute()
        {
            void Rotate()
            {
                int temp = arr[0];
                for (int i = 0; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = temp;
            }
            for (int i = 0; i < k; i++) Rotate();

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
            k = Helper.ReadInt("k");
            arr = Helper.ReadIntArray(n);
        }
    }
}
