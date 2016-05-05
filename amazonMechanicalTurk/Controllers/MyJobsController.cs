using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using amazonMechanicalTurk.Models;

namespace amazonMechanicalTurk.Controllers
{
    public class MyJobsController : Controller
    {
        private DBmechanicalTurkEntities db = new DBmechanicalTurkEntities();

        // GET: MyJobs
        public ActionResult Index()
        {
            return View(db.JobInfoes.ToList());
        }

        public ActionResult Chart(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View();
        }
    }
}