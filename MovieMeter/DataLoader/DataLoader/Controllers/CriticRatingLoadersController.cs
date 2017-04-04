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
    public class CriticRatingLoadersController : Controller
    {
        private DataLoaderEntities db = new DataLoaderEntities();

        // GET: CriticRatingLoaders
        public ActionResult Index()
        {
            var criticRatingLoaders = db.CriticRatingLoaders.Include(c => c.CriticSite).Include(c => c.MovieDetailLoader);
            return View(criticRatingLoaders.ToList());
        }

        // GET: CriticRatingLoaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticRatingLoader criticRatingLoader = db.CriticRatingLoaders.Find(id);
            if (criticRatingLoader == null)
            {
                return HttpNotFound();
            }
            return View(criticRatingLoader);
        }

        // GET: CriticRatingLoaders/Create
        public ActionResult Create()
        {
            ViewBag.CriticSiteId = new SelectList(db.CriticSites, "CriticSiteId", "SiteName");
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl");
            return View();
        }

        // POST: CriticRatingLoaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CriticRatingId,CriticSiteId,MovieDetailID,Rating")] CriticRatingLoader criticRatingLoader)
        {
            if (ModelState.IsValid)
            {
                db.CriticRatingLoaders.Add(criticRatingLoader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CriticSiteId = new SelectList(db.CriticSites, "CriticSiteId", "SiteName", criticRatingLoader.CriticSiteId);
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl", criticRatingLoader.MovieDetailID);
            return View(criticRatingLoader);
        }

        // GET: CriticRatingLoaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticRatingLoader criticRatingLoader = db.CriticRatingLoaders.Find(id);
            if (criticRatingLoader == null)
            {
                return HttpNotFound();
            }
            ViewBag.CriticSiteId = new SelectList(db.CriticSites, "CriticSiteId", "SiteName", criticRatingLoader.CriticSiteId);
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl", criticRatingLoader.MovieDetailID);
            return View(criticRatingLoader);
        }

        // POST: CriticRatingLoaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CriticRatingId,CriticSiteId,MovieDetailID,Rating")] CriticRatingLoader criticRatingLoader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(criticRatingLoader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CriticSiteId = new SelectList(db.CriticSites, "CriticSiteId", "SiteName", criticRatingLoader.CriticSiteId);
            ViewBag.MovieDetailID = new SelectList(db.MovieDetails, "MovieDetailID", "DetailsUrl", criticRatingLoader.MovieDetailID);
            return View(criticRatingLoader);
        }

        // GET: CriticRatingLoaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CriticRatingLoader criticRatingLoader = db.CriticRatingLoaders.Find(id);
            if (criticRatingLoader == null)
            {
                return HttpNotFound();
            }
            return View(criticRatingLoader);
        }

        // POST: CriticRatingLoaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CriticRatingLoader criticRatingLoader = db.CriticRatingLoaders.Find(id);
            db.CriticRatingLoaders.Remove(criticRatingLoader);
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
