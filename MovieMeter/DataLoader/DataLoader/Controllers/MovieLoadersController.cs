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
    public class MovieLoadersController : Controller
    {
        private DataLoaderEntities db = new DataLoaderEntities();

        // GET: MovieLoaders
        public ActionResult Index()
        {
            var movieLoaders = db.MovieLoaders.Include(m => m.Language);
            return View(movieLoaders.ToList());
        }

        // GET: MovieLoaders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieLoader movieLoader = db.MovieLoaders.Find(id);
            if (movieLoader == null)
            {
                return HttpNotFound();
            }
            return View(movieLoader);
        }

        // GET: MovieLoaders/Create
        public ActionResult Create()
        {
            ViewBag.LanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName");
            return View();
        }

        // POST: MovieLoaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,Name,SmallPictureUrl,LargePictureUrl,ReleaseDate,LanguageID")] MovieLoader movieLoader)
        {
            if (ModelState.IsValid)
            {
                db.MovieLoaders.Add(movieLoader);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", movieLoader.LanguageID);
            return View(movieLoader);
        }

        // GET: MovieLoaders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieLoader movieLoader = db.MovieLoaders.Find(id);
            if (movieLoader == null)
            {
                return HttpNotFound();
            }
            ViewBag.LanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", movieLoader.LanguageID);
            return View(movieLoader);
        }

        // POST: MovieLoaders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,Name,SmallPictureUrl,LargePictureUrl,ReleaseDate,LanguageID")] MovieLoader movieLoader)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieLoader).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", movieLoader.LanguageID);
            return View(movieLoader);
        }

        // GET: MovieLoaders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieLoader movieLoader = db.MovieLoaders.Find(id);
            if (movieLoader == null)
            {
                return HttpNotFound();
            }
            return View(movieLoader);
        }

        // POST: MovieLoaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieLoader movieLoader = db.MovieLoaders.Find(id);
            db.MovieLoaders.Remove(movieLoader);
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
