using DataLoader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataLoader.Controllers
{
    public class NewMovieController : Controller
    {
        private DataLoaderEntities db = new DataLoaderEntities();
        // GET: MovieLoaders/Create
        public ActionResult NewView()
        {
            ViewBag.LanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName");
            ViewBag.CriticSiteId = new SelectList(db.CriticSites, "CriticSiteId", "SiteName");
            return View();
        }

        // POST: MovieLoaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewView([Bind(Include = "MovieID,Name,SmallPictureUrl,LargePictureUrl,ReleaseDate,LanguageID")] NewMovieLoader movieLoader)
        {
            if (ModelState.IsValid)
            {
                db.MovieLoaders.Add(movieLoader.Movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LanguageID = new SelectList(db.Languages, "LanguageID", "LanguageName", movieLoader.Movie.LanguageID);
            return View(movieLoader);
        }

    }
}