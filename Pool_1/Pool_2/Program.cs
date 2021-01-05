using Pool_2.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_2
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
