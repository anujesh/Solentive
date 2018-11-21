using Solentive.Interview.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using Solentive.Interview.Model;
using Solentive.Interview.Data;
using Solentive.Interview.Service.Interfaces;
using Solentive.Interview.Logging.Interfaces;

namespace Solentive.Interview.WebUI.Controllers
{
    public class LevelController : BaseController
    {
        public ILevelService _levelService;

        public LevelController(ILevelService levelService, ILoggingService loggingService) : base(loggingService)
        {
            _levelService = levelService;
            _loggingService = loggingService;
        }

        [HttpGet]
        public ActionResult List()
        {
            // Get the source list and map to the view model type.
            var targetList = _levelService.GetLevels().ToList();
            return View(targetList);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new Level();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Level level)
        {
            if (ModelState.IsValid)
            {
                var status = _levelService.AddLevel(level) ? "Saved Successfully!" : "Could not Save!";
                return Json(status);
            }
            return View(level);
        }
    }
}
