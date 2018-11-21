using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Index()
        {
            return View("error");
        }

        public ViewResult NotFound()
        {
            Response.StatusCode = 404;
            return View("NotFound");
        }
    }
}