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
            shortTexts.Add("Is leap year?");
            shortTexts.Add("Swap with temp variable.");
            shortTexts.Add("Swap without temp variable.");
            shortTexts.Add("Divisors of n.");
            shortTexts.Add("Is n prime?");
            shortTexts.Add("Inverse digits.");
            shortTexts.Add("Is n divisble by k? Where n is between [a, b]");
            shortTexts.Add("Is n a leap year? Where n is between [a, b]");
            shortTexts.Add("Is n a palindrome?");
            shortTexts.Add("Sort 3 numbers.");
            shortTexts.Add("Sort 5 numbers.");
            shortTexts.Add("GCD and LCM of two numbers.");
            shortTexts.Add("Prime factorization of n");
            shortTexts.Add("Is n formed by only two different digits?");
            shortTexts.Add("Calculate (periodic) fraction");
            shortTexts.Add("I'll guess the number you're thinking of!");
        }

        private void GenerateFullTexts()
        {
            fullTexts.Add("You have the following linear equation: ax + b = 0. Solve for x.");
            fullTexts.Add("You have the following quadratic equation: ax^2 + bx = 0. Solve for x.");
            fullTexts.Add("Determine if n is divisible by k.");
            fullTexts.Add("Check if a year is a leap year.");
            fullTexts.Add("Swap two variables using a temp variable.");
            fullTexts.Add("Swap two variables without using other variables.");
            fullTexts.Add("Display all the divisors of the number n.");
            fullTexts.Add("Check if the number n is a prime number.");
            fullTexts.Add("Display the digits of n in reverse order.");
            fullTexts.Add("Check how many numbers are divisble by k in the range [a, b]");
            fullTexts.Add("Check how many leap years are there in the range [a, b]");
            fullTexts.Add("Check if n is a palindrome.");
            fullTexts.Add("Sort three numbers a, b and c.");
            fullTexts.Add("Sort five numbers a, b, c, d, e.");
            fullTexts.Add("Calculate the Greatest Common Divisor and Lower Common Multiple of variables a and b.");
            fullTexts.Add("Display the prime factorization of n");
            fullTexts.Add("Check if n formed by only two different digits");
            fullTexts.Add("Show decimal result of the fraction m/n, with possible repeating decimals.");
            fullTexts.Add("I'll guess the number you're thinking of!");
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
