using Solentive.Interview.Common;
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
    public class SeminarController : BaseController
    {      

        private readonly ISeminarService _seminarService;

        public SeminarController(ISeminarService seminarService, ILoggingService loggingService) : base(loggingService)
        {
            _seminarService = seminarService;
            _loggingService = loggingService;
        }

        [HttpGet]
        public ActionResult List()
        {
            // Set the week start and end
            ViewBag.WeekStart = DateCalculations.GetWeekStartDate(DateTime.Now).ToShortDateString();
            ViewBag.WeekEnd = DateCalculations.GetWeekEndDate(DateTime.Now).ToShortDateString();

            // Get the source list and map to the view model type.
            var list = _seminarService.GetSeminars();
            return View(list);
        }
    }
}
