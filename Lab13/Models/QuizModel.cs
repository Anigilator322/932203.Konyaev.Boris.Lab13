namespace Lab13.Models
{
    public class QuizModel
    {
        public List<Question> QuizQuestions { get; private set; }
        public List<QuizUserAnswers> UserAnswers { get; private set; }

        public QuizModel()
        {
            QuizQuestions = new List<Question>();
            UserAnswers = new List<QuizUserAnswers>();
        }

        public void AddQuestion(Question question)
        {
            QuizQuestions.Add(question);
        }

        public void AddUserAnswer(QuizUserAnswers userAnswer)
        {
            UserAnswers.Add(userAnswer);
        }

        public void Reset()
        {
            QuizQuestions.Clear();
            UserAnswers.Clear();
        }
    }
}
