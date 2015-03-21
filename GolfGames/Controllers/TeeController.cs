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
    public class TeeController : Controller
    {
        private CourseContext db = new CourseContext();

        // GET: Tee
        public ActionResult Index()
        {
            var tees = db.Tees.Include(t => t.Golfcourse);
            return View(tees.ToList());
        }

        // GET: Tee/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tee tee = db.Tees.Find(id);
            if (tee == null)
            {
                return HttpNotFound();
            }
            return View(tee);
        }

        // GET: Tee/Create
        public ActionResult Create()
        {
            ViewBag.GolfcourseId = new SelectList(db.Golfcourses, "Id", "Name");
            return View();
        }

        // POST: Tee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Par,Name,Lenght,Scratch,Slope,GolfcourseId")] Tee tee)
        {
            if (ModelState.IsValid)
            {
                db.Tees.Add(tee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GolfcourseId = new SelectList(db.Golfcourses, "Id", "Name", tee.GolfcourseId);
            return View(tee);
        }

        // GET: Tee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tee tee = db.Tees.Find(id);
            if (tee == null)
            {
                return HttpNotFound();
            }
            ViewBag.GolfcourseId = new SelectList(db.Golfcourses, "Id", "Name", tee.GolfcourseId);
            return View(tee);
        }

        // POST: Tee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Par,Name,Lenght,Scratch,Slope,GolfcourseId")] Tee tee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GolfcourseId = new SelectList(db.Golfcourses, "Id", "Name", tee.GolfcourseId);
            return View(tee);
        }

        // GET: Tee/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tee tee = db.Tees.Find(id);
            if (tee == null)
            {
                return HttpNotFound();
            }
            return View(tee);
        }

        // POST: Tee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tee tee = db.Tees.Find(id);
            db.Tees.Remove(tee);
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
