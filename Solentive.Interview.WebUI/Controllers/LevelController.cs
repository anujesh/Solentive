using Solentive.Interview.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections;
using Solentive.Interview.Model;
using Solentive.Interview.Data;

namespace Solentive.Interview.WebUI.Controllers
{
    public class LevelController : Controller
    {
        private SeminarDbContext _seminarDbContext = null;

        public LevelController()
        {
            _seminarDbContext = new SeminarDbContext();
        }

        [HttpGet]
        public ActionResult List()
        {
            // Get the source list and map to the view model type.
            var targetList = _seminarDbContext.Levels.ToList();
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
            if(ModelState.IsValid)
            {
                _seminarDbContext.Levels.Add(level);
                var result = (_seminarDbContext.SaveChanges() > 0);
                ViewBag.HasSaved = result;
            }

            return View(level);
        }
    }
}
