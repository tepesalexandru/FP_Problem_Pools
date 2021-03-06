﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2.Algorithms
{
    class MonotoneSequenceAlgorithm : Algorithm
    {
        int n, x, prev;
        bool asc, desc, mono;
        public override void Compute()
        {
            asc = true; desc = true;
            prev = Helper.ReadInt("x_0");
            for (int i = 1; i < n; i++)
            {
                x = Helper.ReadInt($"x_{i}");
                if (x < prev)
                {
                    desc = false;
                }
                if (x > prev)
                {
                    asc = false;
                }
            }
            mono = asc || desc;
        }

        public override void DisplayAnswer()
        {
            if (mono)
            {
                Console.WriteLine($"The sequence is monotone.");
            } else
            {
                Console.WriteLine($"The sequence is not monotone.");
            }
        }

        public override void ReadInput()
        {
            n = Helper.ReadInt("n");
        }
    }
}
