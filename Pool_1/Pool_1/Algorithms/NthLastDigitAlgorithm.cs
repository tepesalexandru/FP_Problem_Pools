using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class NthLastDigitAlgorithm : Algorithm
    {
        int n, k, numberOfDigits, kthDigit;
        public override void Compute()
        {
            numberOfDigits = 0;
            int temp = n;
            do
            {
                numberOfDigits++;
                temp /= 10;
            } while (temp > 9);

            int numberOfDigitsToRemove = numberOfDigits - k;
            while (numberOfDigitsToRemove != 0)
            {
                n /= 10;
                numberOfDigitsToRemove--;
            }
            kthDigit = n % 10;
        }

        public override void DisplayAnswer()
        {
            Console.Write($"Answer: the k-th digit is {kthDigit}");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
            k = Helper.ReadInt("k");
        }
    }
}
