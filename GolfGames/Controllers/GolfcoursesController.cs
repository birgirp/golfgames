using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GolfGames.DAL;
using GolfGames.Models;

namespace GolfGames.Controllers
{
    public class GolfcoursesController : Controller
    {
        private CourseContext db = new CourseContext();

        // GET: Golfcourses
        public ActionResult Index()
        {
            return View(db.Golfcourses.ToList());
        }

        // GET: Golfcourses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Golfcourse golfcourse = db.Golfcourses.Find(id);
            if (golfcourse == null)
            {
                return HttpNotFound();
            }
            return View(golfcourse);
        }

        // GET: Golfcourses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Golfcourses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,NumberOfHoles,Country")] Golfcourse golfcourse)
        {
            if (ModelState.IsValid)
            {
                db.Golfcourses.Add(golfcourse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(golfcourse);
        }

        // GET: Golfcourses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Golfcourse golfcourse = db.Golfcourses.Find(id);
            if (golfcourse == null)
            {
                return HttpNotFound();
            }
            return View(golfcourse);
        }

        // POST: Golfcourses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,NumberOfHoles,Country")] Golfcourse golfcourse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(golfcourse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(golfcourse);
        }

        // GET: Golfcourses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Golfcourse golfcourse = db.Golfcourses.Find(id);
            if (golfcourse == null)
            {
                return HttpNotFound();
            }
            return View(golfcourse);
        }

        // POST: Golfcourses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Golfcourse golfcourse = db.Golfcourses.Find(id);
            db.Golfcourses.Remove(golfcourse);
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
