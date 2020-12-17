﻿using System;
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
            shortTexts.Add("Linear Equation.");
            shortTexts.Add("Quadratic Equation.");
        }

        private void GenerateFullTexts()
        {
            fullTexts.Add("You have the following linear equation: ax + b = 0. Solve for x.");
            fullTexts.Add("You have the following quadratic equation: ax^2 + bx = 0. Solve for x.");
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
