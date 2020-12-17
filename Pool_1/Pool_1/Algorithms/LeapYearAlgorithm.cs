using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1.Algorithms
{
    class LeapYearAlgorithm : Algorithm
    {
        int year;
        bool isLeapYear;
        public override void Compute()
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    } else
                    {
                        isLeapYear = false;
                    }
                } else
                {
                    isLeapYear = true;
                }
            } else
            {
                isLeapYear = false;
            }
        }

        public override void DisplayAnswer()
        {
            if (isLeapYear)
            {
                Console.WriteLine("Answer: The year introduced is a leap year.");
            } else
            {
                Console.WriteLine("Answer: The year introduced is not a leap year.");
            }
        }

        public override void ReadInput()
        {
            year = Helper.ReadInt("year");
        }
    }
}
