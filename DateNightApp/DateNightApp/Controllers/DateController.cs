using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DateNightApp.Models;

namespace DateNightApp.Controllers
{
    public class DateController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Date
        public ActionResult Index()  //we might want to chance index to something else. This currently this will be called when date/index is called
        {
            var date = new Date();
            return View();
        }
    }
}