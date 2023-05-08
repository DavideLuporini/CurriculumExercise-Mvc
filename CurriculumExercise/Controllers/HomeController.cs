using CurriculumExercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CurriculumExercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Utente utente = Db.GetUtente();
            return View(utente);
        }

        public IActionResult Skills()
        {
            List<Skill> skills = Db.GetAllSkils();
            return View(skills);
        }
        public IActionResult Works()
        {
            List<Lavoro> works = Db.GetAllWorks();
            return View(works);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}