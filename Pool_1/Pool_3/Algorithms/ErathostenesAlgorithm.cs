using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Algorithms
{
    class ErathostenesAlgorithm : Algorithm
    {
        int n;
        bool[] isNotPrime;
        public override void Compute()
        {
            isNotPrime = new bool[n + 1];
            isNotPrime[0] = true;
            isNotPrime[1] = true;
            for(int i = 2; i <= n; i++)
            {
                if (isNotPrime[i] == false)
                {
                    for (int j = i + i; j <= n; j += i)
                    {
                        isNotPrime[j] = true;
                    }
                }
                
            }
        }

        public override void DisplayAnswer()
        {
            Console.Write("Answer:");
            for (int i = 2; i <= n; i++)
            {
                if (isNotPrime[i] == false)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
