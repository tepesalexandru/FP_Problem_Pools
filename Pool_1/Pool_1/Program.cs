using Pool_1.Questions;
using Pool_1.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionsFactory questionsFactory = new QuestionsFactory();
            questionsFactory.DisplayQuestions();
            Console.ReadKey();
        }
    }
}
