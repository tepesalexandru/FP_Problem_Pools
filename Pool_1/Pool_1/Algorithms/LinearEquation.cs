using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class LinearEquation : Algorithm
    {
        float a, b, x;

        public override void Compute()
        {
            this.x = -b / a;
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: x is equal to {this.x}");
        }

        public override void ReadInput()
        {
            this.a = Helper.ReadFloat("a");
            this.b = Helper.ReadFloat("b");
        }
    }
}
