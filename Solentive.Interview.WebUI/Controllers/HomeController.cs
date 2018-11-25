using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {}

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }
    }
}
