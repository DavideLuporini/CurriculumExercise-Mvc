using CurriculumExercise.Filter;
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
    }
}
