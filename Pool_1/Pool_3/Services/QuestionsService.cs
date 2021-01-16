using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_3.Algorithms;

namespace Pool_3.Services
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
            shortTexts.Add("Calculate sum of n elements.");
            shortTexts.Add("Find k in an array.");
            shortTexts.Add("Find position of min and max elements.");
            shortTexts.Add("Count appearences of min and max elements");
            shortTexts.Add("Insert an element on position k in an array");
            shortTexts.Add("Delete an element from an array.");
            shortTexts.Add("Reverse an array.");
            shortTexts.Add("Rotate an array.");
            shortTexts.Add("Rotate an array k times.");
            shortTexts.Add("Find an element in an array.");
        }

        private void GenerateFullTexts()
        {
            fullTexts.Add("Calculate sum of n elements.");
            fullTexts.Add("Find number k in an array of n elements.");
            fullTexts.Add("Find the position of the min and max elements.");
            fullTexts.Add("Count how many times the min and max elements appear in an array of n elements.");
            fullTexts.Add("Insert element e on position k in an array of n elements.");
            fullTexts.Add("Delete an element k from an array of n elements.");
            fullTexts.Add("Reverse an array of n elements.");
            fullTexts.Add("Rotate once an array of n elements.");
            fullTexts.Add("Rotate k times an array of n elements.");
            fullTexts.Add("Find an element k in an array of n elements.");
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
