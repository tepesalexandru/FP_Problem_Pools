using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_1.Algorithms;

namespace Pool_1.Services
{
    class QuestionsService
    {
        List<string> shortTexts;
        List<string> fullTexts;
       
        public QuestionsService()
        {
            shortTexts = new List<string>();
            fullTexts = new List<string>();
            GenerateShortTexts();
            GenerateFullTexts();
        }

        private void GenerateShortTexts()
        {
            shortTexts.Add("Solve a linear equation.");
            shortTexts.Add("Solve a quadratic equation.");
            shortTexts.Add("Is n divisible by k?");
            shortTexts.Add("Check leap year.");
            shortTexts.Add("Swap with temp variable.");
            shortTexts.Add("Swap without temp variable.");
        }

        private void GenerateFullTexts()
        {
            fullTexts.Add("You have the following linear equation: ax + b = 0. Solve for x.");
            fullTexts.Add("You have the following quadratic equation: ax^2 + bx = 0. Solve for x.");
            fullTexts.Add("Determine if n is divisible by k.");
            fullTexts.Add("Check if a year is a leap year.");
            fullTexts.Add("Swap two variables using a temp variable.");
            fullTexts.Add("Swap two variables without using other variables.");
        }

        public List<string> GetShortTexts()
        {
            return shortTexts;
        }

        public List<string> GetFullTexts()
        {
            return fullTexts;
        }

    }
}
