using Lab13.Models;
using Lab13.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab13.Controllers
{
    public class MockupsController : Controller
    {
        private IQuizService _quizService;

        public MockupsController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        public IActionResult Index()
        {
            return View("index");
        }

        [HttpGet]
        public IActionResult Quiz()
        {
            
            QuizModel quiz = _quizService.GetCurrentQuiz();
            _quizService.FinishQuiz(quiz);
            return View("quiz", quiz);
        }

        [HttpPost]
        public IActionResult Quiz(int answer, string action)
        {
            var quiz = _quizService.GetCurrentQuiz();
            
            if(!ModelState.IsValid)
            {
                Question question = _quizService.GetQuestion(quiz);
                return View("quiz", quiz);
            }
            _quizService.AnswerOnQuestion(new QuizUserAnswers(answer), quiz);
            if(action == "next")
            {
                Question question = _quizService.GenerateQuestion(quiz);
                return View("quiz", quiz);
            }
            else
            {
                return View("result",quiz);
            }
        }

        [HttpGet]
        public IActionResult Result()
        {
            var quiz = _quizService.GetCurrentQuiz();
            return View("result",quiz);
        }
    }
}
