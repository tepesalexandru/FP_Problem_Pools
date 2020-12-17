using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class PalindromeAlgorithm : Algorithm
    {
        int n, inverse;
        bool isPalindrome;
        public override void Compute()
        {
            inverse = 0;
            isPalindrome = false;
            int temp = n;
            while (temp != 0)
            {
                inverse = inverse * 10;
                inverse = inverse + temp % 10;
                temp /= 10;
            }
            if (n == inverse)
            {
                isPalindrome = true;
            }
        }

        public override void DisplayAnswer()
        {
            Console.Write("Answer: ");
            if (isPalindrome)
            {
                Console.Write($"{n} is a palindrome.");
            } else
            {
                Console.Write($"{n} is not a palindrome");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
