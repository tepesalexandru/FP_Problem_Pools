using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class SwapAlgorithm : Algorithm
    {
        float a, b;
        public override void Compute()
        {
            a += b;
            b = a - b;
            a = a - b;
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"The variables have been swapped. Current values: a = {a}, b = {b}");
        }

        public override void ReadInput()
        {
            a = Helper.ReadFloat("a");
            b = Helper.ReadFloat("b");
        }
    }
}
