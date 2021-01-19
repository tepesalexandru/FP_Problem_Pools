using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class GroupsAlgorithm : Algorithm
    {
        int n, x, groups;
        public override void Compute()
        {
            int i;
            groups = 0;
            bool inSequence = false;
            for (i = 0; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x != 0)
                {
                    if (!inSequence)
                    {
                        groups++;
                        inSequence = true;
                    }
                } else
                {
                    inSequence = false;
                }
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {groups} groups");
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
