using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class ReverseArrayAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        public override void Compute()
        {
            int aux;
            for (int i = 0; i < n / 2; i++)
            {
                aux = arr[i];
                arr[i] = arr[n - i - 1];
                arr[n - i - 1] = aux;
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
