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
    public class UserRatingLoadersController : Controller
    {
        private DataLoaderEntities db = new DataLoaderEntities();

        // GET: UserRatingLoaders
        public ActionResult Index()
        {
            var userRatingLoaders = db.UserRatingLoaders.Include(u => u.MovieDetailLoader);
            return View(userRatingLoaders.ToList());
        }

        // GET: UserRatingLoaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRatingLoader userRatingLoader = db.UserRatingLoaders.Find(id);
            if (userRatingLoader == null)
            {
                return HttpNotFound();
            }
            return View(userRatingLoader);
        }

        // GET: UserRatingLoaders/Create
        public ActionResult Create()
        {
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl");
            return View();
        }

        // POST: UserRatingLoaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserRatingId,MovieDetailID,Rating,NumberOfUsers")] UserRatingLoader userRatingLoader)
        {
            if (ModelState.IsValid)
            {
                db.UserRatingLoaders.Add(userRatingLoader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl", userRatingLoader.MovieDetailID);
            return View(userRatingLoader);
        }

        // GET: UserRatingLoaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRatingLoader userRatingLoader = db.UserRatingLoaders.Find(id);
            if (userRatingLoader == null)
            {
                return HttpNotFound();
            }
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl", userRatingLoader.MovieDetailID);
            return View(userRatingLoader);
        }

        // POST: UserRatingLoaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserRatingId,MovieDetailID,Rating,NumberOfUsers")] UserRatingLoader userRatingLoader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRatingLoader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl", userRatingLoader.MovieDetailID);
            return View(userRatingLoader);
        }

        // GET: UserRatingLoaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRatingLoader userRatingLoader = db.UserRatingLoaders.Find(id);
            if (userRatingLoader == null)
            {
                return HttpNotFound();
            }
            return View(userRatingLoader);
        }

        // POST: UserRatingLoaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRatingLoader userRatingLoader = db.UserRatingLoaders.Find(id);
            db.UserRatingLoaders.Remove(userRatingLoader);
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
