using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class TwoDigitsAlgorithm : Algorithm
    {
        int n;
        bool hasOnlyTwoDifferentDigits;
        public override void Compute()
        {
            hasOnlyTwoDifferentDigits = false;
            bool[] appearedDigits = new bool[10];
            int numberOfAppearedDigits = 0;
            do
            {
                int lastDigit = n % 10;
                if (appearedDigits[lastDigit] == false) numberOfAppearedDigits++;
                appearedDigits[lastDigit] = true;
                n /= 10;
            } while (n != 0);

            if (numberOfAppearedDigits == 2) hasOnlyTwoDifferentDigits = true;
        }

        public override void DisplayAnswer()
        {
            Console.Write("Answer: ");
            if (hasOnlyTwoDifferentDigits)
            {
                Console.Write("the number has only two different digits.");
            } else
            {
                Console.Write("the number does not have two different digits.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
