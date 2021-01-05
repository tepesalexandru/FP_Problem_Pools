using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    public abstract class Algorithm
    {
        public void Initiate()
        {
            ReadInput();
            Compute();
            DisplayAnswer();
        }
        public abstract void ReadInput();
        public abstract void Compute();
        public abstract void DisplayAnswer();
    }
}
