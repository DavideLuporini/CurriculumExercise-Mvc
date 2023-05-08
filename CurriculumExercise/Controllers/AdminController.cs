using CurriculumExercise.Filter;
using CurriculumExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumExercise.Controllers
{
    public class AdminController : Controller
    {
        [AuthorizationFilter]
        public IActionResult Index()
        {
            return View();
        }
        [AuthorizationFilter]
        public IActionResult AdminArea()
        {
            return View();
        }

        [AuthorizationFilter]
        public IActionResult AddWork()
        {
            return View();
        }

        [AuthorizationFilter]
        public IActionResult AddSkill()
        {
            return View();
        }

        [AuthorizationFilter]
        [HttpPost]
        public IActionResult AddSkill(string nome , string skillValue)
        {
            Db.addSkill(nome , skillValue);
            return View("AddSkill");
        }        [AuthorizationFilter]
        [HttpPost]
        public IActionResult AddWork(string azienda, DateTime dataInizio , DateTime dataFine)
        {
            Db.AddWork(azienda , dataInizio , dataFine);
            return View("AddWork");
        }
    }
}
