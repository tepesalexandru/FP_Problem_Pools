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
            shortTexts.Add("Find an element in an array. (Binary Search)");
            shortTexts.Add("Find all primes smaller than n.");
            shortTexts.Add("Sort an array. (Selection Sort)");
            shortTexts.Add("Sort an array. (Insertion Sort)");
            shortTexts.Add("Move all zeros in an array to the end.");
            shortTexts.Add("Delete all duplicates of an array. (without a secondary array).");
            shortTexts.Add("Find Greated common divisor of an array.");
            shortTexts.Add("Merge two arrays.");
            shortTexts.Add("Find value of a position after the array is sorted.");
            shortTexts.Add("Sort an array. (QuickSort)");
            shortTexts.Add("Sort an array. (MergeSort)");
            shortTexts.Add("Sort an array with double critaria.");
            shortTexts.Add("Find majority element in an array.");
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
            fullTexts.Add("Find all prime numbers smaller than n.");
            fullTexts.Add("Sort an array of n elements using the Selection Sort algorithm.");
            fullTexts.Add("Sort an array of n elements using the Insertion Sort algorithm.");
            fullTexts.Add("Move all zeros in an array of n elements to the end.");
            fullTexts.Add("Delete all duplicates of an array of n elements. (without a secondary array).");
            fullTexts.Add("Find Greated common divisor of an array of n elements.");
            fullTexts.Add("Merge an array of n elements with another array of m elements.");
            fullTexts.Add("Find value of a position after an array of n elements is sorted.");
            fullTexts.Add("Sort an array of n elements using the QuickSort algorithm.");
            fullTexts.Add("Sort an array of n elements using the MergeSort algorithm.");
            fullTexts.Add("Sort an array E of n elements where each element has a weight W.");
            fullTexts.Add("Find if an array of n elements has a majority element.");
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
