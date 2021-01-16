using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class MinMaxAlgorithm : Algorithm
    {
        int n, min, max, min_poz, max_poz;
        int[] arr;
        public override void Compute()
        {
            int i;
            if (n % 2 == 0)
            {
                if (arr[0] > arr[1])
                {
                    max = arr[0];
                    min = arr[1];
                    max_poz = 0;
                    min_poz = 1;
                } else
                {
                    max = arr[1];
                    min = arr[0];
                    max_poz = 1;
                    min_poz = 0;
                }
                i = 2;
            } else
            {
                min = arr[0];
                max = arr[0];
                min_poz = 0;
                max_poz = 0;
                i = 1;
            }

            while (i < n - 1)
            {
                if (arr[i] > arr[i + 1])
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        max_poz = i;
                    }

                    if (arr[i + 1] < min)
                    {
                        min = arr[i + 1];
                        min_poz = i + 1;
                    }
                } else
                {
                    if (arr[i + 1] > max)
                    {
                        max = arr[i + 1];
                        max_poz = i + 1;
                    }

                    if (arr[i] < min)
                    {
                        min = arr[i];
                        min_poz = i;
                    }
                }
                i += 2;
            }

        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: max is on position {max_poz} and min is on position {min_poz}. (starting on index 0)");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = Helper.ReadIntArray(n);
        }
    }
}
