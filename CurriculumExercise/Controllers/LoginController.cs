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
        public IActionResult Login(User u)
        {
            var log = Db.VerifyUtente(u);
            if (log != null)
            {
                HttpContext.Session.SetString("LogSession", log);
            }
            else
            {
                HttpContext.Session.Remove("LogSession");
                return RedirectToAction("Index");
            }
            return RedirectToAction("AdminArea" , "Admin");
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            HttpContext.Connection.RequestClose();
            Db.LogginOut();
            return RedirectToAction("Index");
        }
    }
}
