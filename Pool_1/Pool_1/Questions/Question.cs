using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_1.Algorithms;

namespace Pool_1.Questions
{
    public class Question
    {
        string shortText;
        string fullText;
        Algorithm algorithm;
        public Question(string shortText, string fullText, Algorithm algorithm)
        {
            this.shortText = shortText;
            this.fullText = fullText;
            this.algorithm = algorithm;
        }

        public void DisplayShortTextWithIndex(int index)
        {
            Console.WriteLine($"{index}. {this.shortText}");
        }
        public void DisplayFullText()
        {
            Console.Clear();
            Console.Write(this.fullText);
            Console.WriteLine();
        }

        public void InitiateAlgorithm()
        {
            this.algorithm.Initiate();
        }

    }
}
