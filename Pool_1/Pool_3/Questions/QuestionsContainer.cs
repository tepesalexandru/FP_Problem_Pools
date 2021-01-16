using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_3.Questions
{
    public class QuestionsContainer
    {
        List<Question> questions;

        public QuestionsContainer()
        {
            this.questions = new List<Question>();
        }

        public void DisplayShortTextForAllQuestions()
        {
            int i = 1;
            foreach(Question question in questions)
            {
                question.DisplayShortTextWithIndex(i++);
            }
        }

        public void OpenQuestionWithIndex(int index)
        {
            this.questions[index - 1].DisplayFullText();
            this.questions[index - 1].InitiateAlgorithm();

            Console.WriteLine("\nPress any key to go back to the main menu.");
            Console.ReadKey();
        }

        public void AddQuestion(Question newQuestion)
        {
            questions.Add(newQuestion);
        }
    }
}
