using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class RotateAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        public override void Compute()
        {
            int temp = arr[0];
            for (int i = 0; i < n - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[n - 1] = temp;
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
