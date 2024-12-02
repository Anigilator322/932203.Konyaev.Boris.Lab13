using Lab13.Models;

namespace Lab13.Services
{
    public interface IQuizService
    {
        //public QuizModel GenerateQuiz();
        public QuizModel GetCurrentQuiz();
        public Question GetQuestion(QuizModel quiz);
        public void FinishQuiz(QuizModel quiz);
        public void AnswerOnQuestion(QuizUserAnswers answer, QuizModel quiz);
        public Question GenerateQuestion(QuizModel quiz);
    }
}
