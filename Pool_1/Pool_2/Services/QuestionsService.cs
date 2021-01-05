using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_2.Algorithms;

namespace Pool_2.Services
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
            shortTexts.Add("Count even numbers.");
            shortTexts.Add("Count negative, equal to zero and positive numbers.");
            shortTexts.Add("Sum and product of the first n positive numbers.");
            shortTexts.Add("Find a number in a sequence.");
            shortTexts.Add("Count numbers equal to their position.");
            shortTexts.Add("Is the sequence ascending?");
            shortTexts.Add("Min and max values from a sequence.");
            shortTexts.Add("Find the nth fibonacci number.");
            shortTexts.Add("Is the sequence monotone?");
            shortTexts.Add("Max equal subsequence.");
        }

        private void GenerateFullTexts()
        {
            fullTexts.Add("Count even numbers.");
            fullTexts.Add("Count negative, equal to zero and positive numbers.");
            fullTexts.Add("Sum and product of the first n positive numbers.");
            fullTexts.Add("Find a number in a sequence.");
            fullTexts.Add("Count numbers equal to their position.");
            fullTexts.Add("Is the sequence ascending?");
            fullTexts.Add("Min and max values from a sequence.");
            fullTexts.Add("Find the nth fibonacci number.");
            fullTexts.Add("Is the sequence monotone?");
            fullTexts.Add("Max equal subsequence.");
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
