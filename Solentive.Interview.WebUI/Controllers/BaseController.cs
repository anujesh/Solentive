using Solentive.Interview.Logging.Interfaces;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class BaseController : Controller
    {
        public ILoggingService _loggingService;

        public BaseController(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null)
                base.OnException(filterContext);

            _loggingService.LogError(filterContext.Exception.ToString());
        }
    }
}