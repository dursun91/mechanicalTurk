using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using amazonMechanicalTurk.Models;

namespace amazonMechanicalTurk.Controllers
{
    public class TaskController : Controller
    {
        private DBmechanicalTurkEntities db = new DBmechanicalTurkEntities();
        // GET: Task
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Available()
        {
            return View(db.JobInfoes.ToList());
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "JobID,JobTitle,JobDescription,JobExplanation,JobActive,JobCountRequired,JobCountDone,TimeSt")] JobInfo jobInfo)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    db.JobInfoes.Add(jobInfo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Task/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
