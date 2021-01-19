using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class RotatedAscendingSequenceAlgorithm : Algorithm
    {
        int n, x;
        bool rotatedAscending;
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
            rotatedAscending = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isAscending())
                {
                    rotatedAscending = true;
                }
                Rotate();
            }
        }

        public override void DisplayAnswer()
        {
            if (rotatedAscending)
            {
                Console.WriteLine("Answer: the sequence is a rotated ascending sequence.");
            }
            else
            {
                Console.WriteLine("Answer: the sequence is not a rotated ascending sequence.");
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
