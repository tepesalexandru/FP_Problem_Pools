using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class MergeAlgorithm : Algorithm
    {
        int n, m;
        int[] arr1, arr2, arr3;
        public override void Compute()
        {
            arr3 = new int[n + m];
            int i = 0, j = 0, k = 0;
            while (i < n && j < m)
            {
                if (arr1[i] < arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                }
                else
                {
                    arr3[k] = arr2[j];
                    j++;
                }
                k++;
            }

            while (i < n)
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }

            while (j < m)
            {
                arr3[k] = arr2[j];
                j++;
                k++;

            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine("Answer:");
            for (int i = 0; i < n + m; i++)
            {
                Console.Write(arr3[i] + " ");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr1 = Helper.ReadIntArray(n);
            m = Helper.ReadInt("m");
            arr2 = Helper.ReadIntArray(m);
        }
    }
}
