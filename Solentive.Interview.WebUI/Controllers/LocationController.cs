using Solentive.Interview.Model;
using Solentive.Interview.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class LocationController : Controller
    {
        private LocationService _locationService = null;

        public LocationController()
        {
            _locationService = new LocationService();
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
                var result = _locationService.AddLocation(location);
                ViewBag.HasSaved = result;
            }

            return View(location);
        }
    }
}
