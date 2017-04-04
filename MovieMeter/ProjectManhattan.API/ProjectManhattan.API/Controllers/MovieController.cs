using System;
using System.Linq;
using System.Web.Mvc;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Repository;

namespace ProjectManhattan.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = MovieRepository.Instance.GetAllEntities();
            return View(movies.ToList());
        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            var result = new JsonResult();
            result.Data = MovieRepository.Instance.GetMovieInfo(id.Value);
            return result;
        }
        // GET: Movies2/Create
        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        // POST: Movies2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,Name,SmallPictureUrl,LargePictureUrl,HasReleased,LanguageID")] MovieDTO movie)
        {
            throw new NotImplementedException();
        }

        // GET: Movies2/Edit/5
        public ActionResult Edit(int? id)
        {
            throw new NotImplementedException();
        }

        // POST: Movies2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,Name,SmallPicture,LargePicture,HasReleased,LanguageID")] MovieDTO movie)
        {
            throw new NotImplementedException();
        }

        // GET: Movies2/Delete/5
        public ActionResult Delete(int? id)
        {
            throw new NotImplementedException();
        }

        // POST: Movies2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            
        }
    }
}
