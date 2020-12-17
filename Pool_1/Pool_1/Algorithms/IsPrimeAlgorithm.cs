using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class IsPrimeAlgorithm : Algorithm
    {
        int n;
        List<int> divisors;
        bool isPrime;
        public override void Compute()
        {
            divisors = new List<int>();
            isPrime = false;
            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i * i != n)
                    {
                        divisors.Add(n / i);
                    }
                }
            }
            if (divisors.Count == 2) isPrime = true;
            else isPrime = false;
        }

        public override void DisplayAnswer()
        {
            Console.Write("Answer: ");
            if (isPrime)
            {
                Console.Write($"{n} is prime.");
            } else
            {
                Console.Write($"{n} is not prime.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
