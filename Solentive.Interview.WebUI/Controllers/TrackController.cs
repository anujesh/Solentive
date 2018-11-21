using Solentive.Interview.Logging.Interfaces;
using Solentive.Interview.Model;
using Solentive.Interview.Service;
using Solentive.Interview.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Solentive.Interview.WebUI.Controllers
{
    public class TrackController : BaseController
    {
        private readonly ITrackService _trackService;

        public TrackController(ITrackService trackService, ILoggingService loggingService) : base(loggingService)
        {
            _trackService = trackService;
            _loggingService = loggingService;
        }

        [HttpGet]
        public ActionResult List()
        {
            // Get the source list and map to the view model type.
            var list = _trackService.GetTracks();
            return View(list);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new Track();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Track track)
        {
            if (ModelState.IsValid)
            {
                var status = _trackService.AddTrack(track) ? "Saved Successfully!" : "Could not Save!";
                return Json(status);
            }

            return View(track);
        }
    }
}
