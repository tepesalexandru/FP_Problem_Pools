using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class RotatedMonotoneSequenceAlgorithm : Algorithm
    {
        int n, x, prev;
        bool monotone, rotatedMonotone;
        int[] arr;
        public override void Compute()
        {
            void Rotate()
            {
                int first = arr[0];
                for (int i = 0; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = first;
            }
            bool isAscending()
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        ok = false;
                    }
                }
                return ok;
            }
            bool isDescending()
            {
                bool ok = true;
                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        ok = false;
                    }
                }
                return ok;
            }
            rotatedMonotone = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isAscending() || isDescending())
                {
                    rotatedMonotone = true;
                }
                Rotate();
            }
        }

        public override void DisplayAnswer()
        {
            if (rotatedMonotone)
            {
                Console.WriteLine("Answer: the sequence is a rotated monotone sequence.");
            }
            else
            {
                Console.WriteLine("Answer: the sequence is not a rotated monotone sequence.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Helper.ReadInt($"x_{i}");
            }
        }
    }
}
