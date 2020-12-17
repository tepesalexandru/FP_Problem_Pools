using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class AuxSwapAlgorithm : Algorithm
    {
        float a, b, aux;
        public override void Compute()
        {
            aux = a;
            a = b;
            b = aux;
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
