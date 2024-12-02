using System.ComponentModel.DataAnnotations;

namespace Lab13.Models
{
    public class QuizUserAnswers
    {
        [Required]
        public int Answer { get; set; }

        public QuizUserAnswers(int answer)
        {
            Answer = answer;
        }
    }
}
