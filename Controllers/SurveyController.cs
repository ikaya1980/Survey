using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survey.Models;

namespace Survey.Controllers
{
    public class SurveyController : Controller
    {
        private readonly SurveyDbContext context;

        public SurveyController(SurveyDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index(int? number)
        {
            int no = number ?? 1;
            Question question = context.Questions.Include(q => q.Sections).First(i => i.QuestionNo == no);
            return View(question);
        }

        [HttpPost]
        public IActionResult Index(Question question)
        {
            return View();
        }
    }
}
