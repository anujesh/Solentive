using Solentive.Interview.Logging.Interfaces;
using Solentive.Interview.Model;
using Solentive.Interview.Service.Interfaces;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class LocationController : BaseController
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService, ILoggingService loggingService) : base(loggingService)
        {
            _locationService = locationService;
            _loggingService = loggingService;
        }

        [HttpGet]
        public ActionResult List()
        {
            // Get the source list and map to the view model type.
            var list = _locationService.GetLocations();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new Location();
            return View(model);
        }


        [HttpPost]
        public ActionResult Add(Location location)
        {
            if (ModelState.IsValid)
            {
                var status = _locationService.AddLocation(location) ? "Saved Successfully!" : "Could not Save!";
                return Json(status);
            }
            return View(location);
        }
    }
}
