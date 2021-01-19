using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class SelectionSortAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        public override void Compute()
        {
            int i, j, imin;
            for (i = 0; i < n - 1; i++)
            {
                imin = i;
                for (j = i + 1; j < n; j++)
                {
                    if (arr[imin] > arr[j])
                    {
                        imin = j;
                    }
                }
                int aux = arr[imin];
                arr[imin] = arr[i];
                arr[i] = aux;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine("Answer:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
