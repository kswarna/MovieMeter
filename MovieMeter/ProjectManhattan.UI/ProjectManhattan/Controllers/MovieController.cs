using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DTO;
using ProjectManhattan.ViewModel;

namespace ProjectManhattan.Controllers
{
    public class MovieController : Controller
    {
        private ProjectManhattanEntities _db = new ProjectManhattanEntities();

        // GET: Movie
        public ActionResult Index()
        {
            var movies = _db.Movies.Include(m => m.Language);
            return View(movies.ToList());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movie = _db.Movies.First(r => r.MovieID == id);
            var movieDetail = _db.MovieDetails.First(r => r.MovieID == id).MovieDetailDto();
            var criticRatings = _db.CriticRatings.Where(r => r.MovieDetailID == movieDetail.MovieDetailID);
            var userRating = _db.UserRatings.FirstOrDefault(r => r.MovieDetailID == movieDetail.MovieDetailID)?.UserRatingDto();
            var criticsites = criticRatings.Select(criticRating => criticRating.CriticSite);
            var ViewModel = new MovieDetailViewModel(new MovieComplete
            {
                Movie = movie.MovieDto(),
                MovieDetail = movieDetail,
                UserRatings = userRating,
                CriticRatings = CriticRating.CriticRatingLsitDto(criticRatings).ToList(),
                CriticSites = CriticSite.CriticSiteLsitDto(criticsites).ToList()
            });
            return View(ViewModel);
        }
        // GET: Movies2/Create
        public ActionResult Create()
        {
            ViewBag.LanguageID = new SelectList(_db.Languages, "LanguageID", "LanguageName");
            return View();
        }

        // POST: Movies2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,Name,SmallPictureUrl,LargePictureUrl,HasReleased,LanguageID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LanguageID = new SelectList(_db.Languages, "LanguageID", "LanguageName", movie.LanguageID);
            return View(movie);
        }

        // GET: Movies2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.LanguageID = new SelectList(_db.Languages, "LanguageID", "LanguageName", movie.LanguageID);
            return View(movie);
        }

        // POST: Movies2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,Name,SmallPictureUrl,LargePictureUrl,HasReleased,LanguageID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(movie).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LanguageID = new SelectList(_db.Languages, "LanguageID", "LanguageName", movie.LanguageID);
            return View(movie);
        }

        // GET: Movies2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = _db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = _db.Movies.Find(id);
            _db.Movies.Remove(movie);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
