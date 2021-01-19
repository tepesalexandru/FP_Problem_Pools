using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class QuickSortAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        public override void Compute()
        {
            void Swap(ref int a, ref int b)
            {
                int aux = a;
                a = b;
                b = aux;
            }
            int Partition(int[] arr, int low, int high)
            {
                int pivot = arr[high];
                int i = low - 1;
                for (int j = low; j < high; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        Swap(ref arr[i], ref arr[j]);
                    }
                }
                Swap(ref arr[i + 1], ref arr[high]);
                return (i + 1);
            }
            void QuickSort(int[] arr, int low, int high)
            {
                if (low < high)
                {
                    int pi = Partition(arr, low, high);

                    QuickSort(arr, low, pi - 1);
                    QuickSort(arr, pi + 1, high);
                }
            }
            QuickSort(arr, 0, n - 1);
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
