using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class DoubleSortAlgorithm : Algorithm
    {
        int n;
        int[] E, W;
        public override void Compute()
        {
            int i, j;
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (E[i] > E[j])
                    {
                        Helper.Swap(ref E[i], ref E[j]);
                        Helper.Swap(ref W[i], ref W[j]);
                    } else if (E[i] == E[j])
                    {
                        if (W[i] > W[j])
                        {
                            Helper.Swap(ref W[i], ref W[j]);
                        }
                    }
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine("Answer:");
            Console.Write("E: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(E[i] + " ");
            }
            Console.WriteLine();
            Console.Write("W: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(W[i] + " ");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            E = Helper.ReadIntArray(n);
            W = Helper.ReadIntArray(n);

        }
    }
}
