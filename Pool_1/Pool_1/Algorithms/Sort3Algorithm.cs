using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class Sort3Algorithm : Algorithm
    {
        int a, b, c;
        public override void Compute()
        {
            void Swap(ref int x, ref int y)
            {
                int aux = x;
                x = y;
                y = aux;
            }

            if (a > b) Swap(ref a, ref b);
            if (a > c) Swap(ref a, ref c);
            if (b > c) Swap(ref b, ref c);

        }

        public override void DisplayAnswer()
        {
            Console.Write($"The sorted numbers are: {a} {b} {c}");
        }

        public override void ReadInput()
        {
            a = Helper.ReadInt("a");
            b = Helper.ReadInt("b");
            c = Helper.ReadInt("c");
        }
    }
}
