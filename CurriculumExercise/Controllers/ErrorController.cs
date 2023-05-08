using Microsoft.AspNetCore.Mvc;

namespace CurriculumExercise.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult PageNotFound()
        {
            return View("~/Views/Shared/PageNotFound.cshtml");
        }
    }
}
