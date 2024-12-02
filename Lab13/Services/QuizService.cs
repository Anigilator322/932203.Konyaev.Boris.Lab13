using Lab13.Models;

namespace Lab13.Services
{
    public class QuizService: IQuizService
    {
        private QuizModel _currentQuiz;

        public QuizModel GetCurrentQuiz()
        {
            if (_currentQuiz == null)
            {
                _currentQuiz = new QuizModel();
            }
            return _currentQuiz;
        }

        public Question GetQuestion(QuizModel quiz)
        {
            if (quiz.QuizQuestions.Count == 0)
            {
                GenerateQuestion(quiz);
            }
            return quiz.QuizQuestions.Last();
        }

        public Question GenerateQuestion(QuizModel quiz)
        {
            Random random = new Random();
            int firstNum = random.Next(1, 10);
            int secondNum = random.Next(1, 10);
            int operNumeric = random.Next(1, 2);
            int answer = 0;
            string oper = "";
            switch (operNumeric)
            {
                case 1:
                    oper = "+";
                    answer = firstNum + secondNum;
                    break;
                case 2:
                    oper = "-";
                    answer = firstNum - secondNum;
                    break;
                default:
                    oper = "+";
                    answer = firstNum + secondNum;
                    break;

            }
            var question = new Question(firstNum, secondNum, oper, answer);
            quiz.AddQuestion(question);
            return question;
        }

        public void AnswerOnQuestion(QuizUserAnswers answer, QuizModel quiz)
        {
            if(quiz.UserAnswers.Count != quiz.QuizQuestions.Count)
            {
                quiz.UserAnswers.Add(answer);
            }
        }

        public void FinishQuiz(QuizModel quiz)
        {
            quiz.Reset();
        }
    }
}
