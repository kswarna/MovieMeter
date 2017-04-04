using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataLoader;

namespace DataLoader.Controllers
{
    public class MovieDetailLoadersController : Controller
    {
        private DataLoaderEntities db = new DataLoaderEntities();

        // GET: MovieDetailLoaders
        public ActionResult Index()
        {
            var movieDetailLoaders = db.MovieDetailLoaders.Include(m => m.MovieLoader);
            return View(movieDetailLoaders.ToList());
        }

        // GET: MovieDetailLoaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDetailLoader movieDetailLoader = db.MovieDetailLoaders.Find(id);
            if (movieDetailLoader == null)
            {
                return HttpNotFound();
            }
            return View(movieDetailLoader);
        }

        // GET: MovieDetailLoaders/Create
        public ActionResult Create()
        {
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Name");
            return View();
        }

        // POST: MovieDetailLoaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieDetailID,MovieID,DetailsUrl,GalleryUrl,TraillerUrl,ScheduleUrl")] MovieDetailLoader movieDetailLoader)
        {
            if (ModelState.IsValid)
            {
                db.MovieDetailLoaders.Add(movieDetailLoader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Name", movieDetailLoader.MovieID);
            return View(movieDetailLoader);
        }

        // GET: MovieDetailLoaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDetailLoader movieDetailLoader = db.MovieDetailLoaders.Find(id);
            if (movieDetailLoader == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Name", movieDetailLoader.MovieID);
            return View(movieDetailLoader);
        }

        // POST: MovieDetailLoaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieDetailID,MovieID,DetailsUrl,GalleryUrl,TraillerUrl,ScheduleUrl")] MovieDetailLoader movieDetailLoader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieDetailLoader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieID = new SelectList(db.Movies, "MovieID", "Name", movieDetailLoader.MovieID);
            return View(movieDetailLoader);
        }

        // GET: MovieDetailLoaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieDetailLoader movieDetailLoader = db.MovieDetailLoaders.Find(id);
            if (movieDetailLoader == null)
            {
                return HttpNotFound();
            }
            return View(movieDetailLoader);
        }

        // POST: MovieDetailLoaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieDetailLoader movieDetailLoader = db.MovieDetailLoaders.Find(id);
            db.MovieDetailLoaders.Remove(movieDetailLoader);
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
