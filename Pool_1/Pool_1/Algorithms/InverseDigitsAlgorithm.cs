using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class InverseDigitsAlgorithm : Algorithm
    {
        int n;
        public override void Compute()
        {
            
        }

        public override void DisplayAnswer()
        {
            Console.Write("Answer: ");
            do
            {
                Console.Write(n % 10);
                n /= 10;
            } while (n != 0);
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
