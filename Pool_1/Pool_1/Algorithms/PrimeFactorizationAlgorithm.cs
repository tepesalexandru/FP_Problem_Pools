using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class PrimeFactorizationAlgorithm : Algorithm
    {
        int n;
        public override void Compute()
        {
            int power, divisor;
            bool foundFirst = false;
            Console.Write("Answer: ");
            int originalN = n;
            for (int i = 2; i <= originalN; i++)
            {
                if (n % i == 0)
                {
                    power = 0;
                    divisor = i;
                    while (n % i == 0)
                    {
                        power++;
                        n /= i;
                    }
                    if (foundFirst) Console.Write(" x ");
                    Console.Write($"{divisor}^{power}");
                    foundFirst = true;
                }
            }
        }

        public override void DisplayAnswer()
        {
            
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
