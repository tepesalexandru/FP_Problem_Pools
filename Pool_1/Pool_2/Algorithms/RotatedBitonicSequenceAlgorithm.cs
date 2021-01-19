using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class RotatedBitonicSequenceAlgorithm : Algorithm
    {
        int n;
        int[] arr;
        bool isRotatedBitonicSequence;
        public override void Compute()
        {
            bool isBitonicSequence()
            {
                int i, max, imax = 0;
                bool isBitonic = true;
                max = arr[0];
                for (i = 1; i < n; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                        imax = i;
                    }
                }
                if (imax == 0 || imax == n - 1) isBitonic = false;
                for (i = 0; i < imax; i++)
                {
                    if (arr[i] > arr[i + 1]) isBitonic = false;
                }
                for (i = imax; i < n - 1; i++)
                {
                    if (arr[i] < arr[i + 1]) isBitonic = false;
                }
                return isBitonic;
            }
            void Rotate()
            {
                int first = arr[0];
                for (int i = 0; i < n - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[n - 1] = first;
            }
            isRotatedBitonicSequence = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (isBitonicSequence())
                {
                    isRotatedBitonicSequence = true;
                }
                Rotate();
            }
        }

        public override void DisplayAnswer()
        {
            if (isRotatedBitonicSequence)
            {
                Console.WriteLine("Answer: the sequence is a rotated bitonic sequence.");
            }
            else
            {
                Console.WriteLine("Answer: the sequence is not a rotated bitonic sequence.");
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
