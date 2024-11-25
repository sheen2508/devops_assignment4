using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using QuizApp.Models;
using QuizApp.Extensions;
using System.Linq;

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StartQuiz()
        {
            var questions = QuestionPool.GetQuestions();
            var randomQuestions = questions.OrderBy(q => Guid.NewGuid()).Take(20).ToList();

            HttpContext.Session.Set("Questions", randomQuestions);
            HttpContext.Session.SetInt32("Score", 0);
            HttpContext.Session.SetInt32("CurrentQuestionIndex", 0);

            return RedirectToAction("Question");
        }

        public IActionResult Question()
        {
            var questions = HttpContext.Session.Get<List<Question>>("Questions");
            var index = HttpContext.Session.GetInt32("CurrentQuestionIndex") ?? 0;

            if (index >= questions.Count) 
                return RedirectToAction("Result");

            ViewBag.Question = questions[index];
            ViewBag.QuestionNumber = index + 1;

            var selectedAnswers = HttpContext.Session.Get<Dictionary<int, int>>("SelectedAnswers") ?? new Dictionary<int, int>();
            ViewBag.SelectedOptionIndex = selectedAnswers.ContainsKey(index) ? selectedAnswers[index] : -1;

            return View();
        }

        [HttpPost]
        public IActionResult SubmitAnswer(int selectedOptionIndex)
        {
            var questions = HttpContext.Session.Get<List<Question>>("Questions");
            var index = HttpContext.Session.GetInt32("CurrentQuestionIndex") ?? 0;

            var selectedAnswers = HttpContext.Session.Get<Dictionary<int, int>>("SelectedAnswers") ?? new Dictionary<int, int>();
            selectedAnswers[index] = selectedOptionIndex;
            HttpContext.Session.Set("SelectedAnswers", selectedAnswers);

            if (questions[index].CorrectAnswerIndex == selectedOptionIndex)
            {
                var score = HttpContext.Session.GetInt32("Score") ?? 0;
                HttpContext.Session.SetInt32("Score", score + 1);
            }

            HttpContext.Session.SetInt32("CurrentQuestionIndex", index + 1);
            return RedirectToAction("Question");
        }

        public IActionResult Result()
        {
            var score = HttpContext.Session.GetInt32("Score") ?? 0;
            ViewBag.Score = score;

            if (score >= 16)
                ViewBag.Message = "You have successfully passed the test.";
            else
                ViewBag.Message = "Unfortunately you did not pass the test. Please try again later.";

            return View();
        }
    }
}
