using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class DivisorsAlgorithm : Algorithm
    {
        int n;
        List<int> divisors;
        public override void Compute()
        {
            divisors = new List<int>();
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
            divisors.Sort();
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: the divisors of {n} are: ");
            foreach(int divisor in divisors)
            {
                Console.Write($"{divisor} ");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
