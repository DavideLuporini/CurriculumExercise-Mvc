using CurriculumExercise.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumExercise.Controllers
{
    public class SubscriptionController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult SubscriptionError()
        {

            return View();
        }

        public IActionResult Subscription(User u)
        {
            Db.AddNewUser(u);
            if (Db.AddNewUser(u)) return RedirectToAction("Index", "Login");
            return RedirectToAction("SubscriptionError", "Subscription");

        }
    }
}
