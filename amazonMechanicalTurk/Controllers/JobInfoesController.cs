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
    public class JobInfoesController : Controller
    {
        private DBmechanicalTurkEntities db = new DBmechanicalTurkEntities();

        // GET: JobInfoes
        public ActionResult Index()
        {
            return View(db.JobInfoes.ToList());
        }

        // GET: JobInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobInfo jobInfo = db.JobInfoes.Find(id);
            if (jobInfo == null)
            {
                return HttpNotFound();
            }
            return View(jobInfo);
        }

        // GET: JobInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JobID,JobTitle,JobDescription,JobExplanation,JobActive,JobCountRequired,JobCountDone,TimeSt")] JobInfo jobInfo)
        {
            if (ModelState.IsValid)
            {
                db.JobInfoes.Add(jobInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jobInfo);
        }

        // GET: JobInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobInfo jobInfo = db.JobInfoes.Find(id);
            if (jobInfo == null)
            {
                return HttpNotFound();
            }
            return View(jobInfo);
        }

        // POST: JobInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JobID,JobTitle,JobDescription,JobExplanation,JobActive,JobCountRequired,JobCountDone,TimeSt")] JobInfo jobInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jobInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jobInfo);
        }

        // GET: JobInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            JobInfo jobInfo = db.JobInfoes.Find(id);
            if (jobInfo == null)
            {
                return HttpNotFound();
            }
            return View(jobInfo);
        }

        // POST: JobInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            JobInfo jobInfo = db.JobInfoes.Find(id);
            db.JobInfoes.Remove(jobInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
