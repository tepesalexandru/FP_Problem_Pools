using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pool_3.Algorithms;
using Pool_3.Services;

namespace Pool_3.Questions
{
    public class QuestionsFactory
    {
        public QuestionsContainer questionsContainer;
        private QuestionsService questionsService;
        private AlgorithmsService algorithmService;
        public QuestionsFactory()
        {
            this.questionsContainer = new QuestionsContainer();
            this.questionsService = new QuestionsService();
            this.algorithmService = new AlgorithmsService();
            this.InitiatePool1();
        }
        public void InitiatePool1()
        {
            List<string> shortTexts = questionsService.GetShortTexts();
            List<string> fullTexts = questionsService.GetFullTexts();
            List<Algorithm> algorithms = algorithmService.GetAlgorithms();
            for (int i = 0; i < shortTexts.Count; i++)
            {
                questionsContainer.AddQuestion(CreateQuestion(shortTexts[i], fullTexts[i], algorithms[i]));
            }
        }

        public Question CreateQuestion(string shortText, string fullText, Algorithm algorithm)
        {
            return new Question(shortText, fullText, algorithm);
        }

        public void DisplayQuestions()
        {
            questionsContainer.DisplayShortTextForAllQuestions();

            Console.Write("Choose your question: ");
            string input = Console.ReadLine();
            int selectedQuestionIndex = Int32.Parse(input);

            questionsContainer.OpenQuestionWithIndex(selectedQuestionIndex);
            Console.Clear();
            DisplayQuestions();
        }

    }
}
