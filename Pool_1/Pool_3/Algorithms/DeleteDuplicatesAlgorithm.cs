using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class DeleteDuplicatesAlgorithm : Algorithm
    {
        int n, newSize;
        int[] arr;
        public override void Compute()
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }

            int nextPos = 1;
            for (i = 1; i < n; i++)
            {
                while (arr[i] == arr[i - 1] && i < n)
                {
                    if (i + 1 == n) break;
                    i++;
                }
                arr[nextPos] = arr[i];
                nextPos++;
            }
            newSize = nextPos - 1;
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine("Answer:");
            for (int i = 0; i < newSize; i++)
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
