using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumExercise.Filter
{
    public class AuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.Get("LogSession") == null)
            {
                context.Result  = new RedirectToActionResult("SessionExpired", "Login", null); 
            }
        }
    }
}
    
