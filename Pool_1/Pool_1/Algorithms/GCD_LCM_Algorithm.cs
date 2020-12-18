using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class GCD_LCM_Algorithm : Algorithm
    {
        int a, b;
        int gcd, lcm;
        public override void Compute()
        {
            int GCD(int x, int y)
            {
                if (y == 0) return x;
                return GCD(y, x % y);
            }

            int LCM(int x, int y)
            {
                return (x * y) / GCD(x, y);
            }
            gcd = GCD(a, b);
            lcm = LCM(a, b);
        }

        public override void DisplayAnswer()
        {
            Console.Write($"Answer: Greatest Common Divisor: {gcd}. Lowest Common Multiple: {lcm}");
        }

        public override void ReadInput()
        {
            a = Helper.ReadInt("a");
            b = Helper.ReadInt("b");
        }
    }
}
