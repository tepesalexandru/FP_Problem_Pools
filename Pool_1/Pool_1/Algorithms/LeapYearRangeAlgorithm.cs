using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class LeapYearRangeAlgorithm : Algorithm
    {
        int a, b, result;
        public override void Compute()
        {
            result = 0;
            for (int i = a; i <= b; i++)
            {
                int year = i;
                bool isLeapYear;
                if (year % 4 == 0)
                {
                    if (year % 100 == 0)
                    {
                        if (year % 400 == 0)
                        {
                            isLeapYear = true;
                        }
                        else
                        {
                            isLeapYear = false;
                        }
                    }
                    else
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = false;
                }
                if (isLeapYear) result++;
            }
        }

        public override void DisplayAnswer()
        {
            Console.WriteLine($"Answer: {result} years.");
        }

        public override void ReadInput()
        {
            a = Helper.ReadInt("a");
            b = Helper.ReadInt("b");
        }
    }
}
