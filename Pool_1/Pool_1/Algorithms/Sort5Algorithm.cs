using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class Sort5Algorithm : Algorithm
    {
        int a, b, c, d, e;
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
            if (a > d) Swap(ref a, ref d);
            if (a > e) Swap(ref a, ref e);

            if (b > c) Swap(ref b, ref c);
            if (b > d) Swap(ref b, ref d);
            if (b > e) Swap(ref b, ref e);

            if (c > d) Swap(ref c, ref d);
            if (c > e) Swap(ref c, ref e);

            if (d > e) Swap(ref d, ref e);

        }

        public override void DisplayAnswer()
        {
            Console.Write($"The sorted numbers are: {a} {b} {c} {d} {e}");
        }

        public override void ReadInput()
        {
            a = Helper.ReadInt("a");
            b = Helper.ReadInt("b");
            c = Helper.ReadInt("c");
            d = Helper.ReadInt("d");
            e = Helper.ReadInt("e");
        }
    }
}
