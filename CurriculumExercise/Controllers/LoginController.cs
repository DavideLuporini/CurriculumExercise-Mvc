using CurriculumExercise.Filter;
using CurriculumExercise.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumExercise.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SessionExpired()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(Utente u)
        {
            var log = Db.VerifyUtente(u);
            if (log != null)
            {
                HttpContext.Session.SetString("LogSession", log);
                HttpContext.Session.SetInt32("IsAuthenticated", 1);
            }
            else
            {
                HttpContext.Session.Remove("LogSession");
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index" , "Admin");
        }
    }
}
