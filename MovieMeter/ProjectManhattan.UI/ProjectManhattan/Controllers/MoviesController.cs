using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using DTO;

namespace ProjectManhattan.Controllers
{
    public class MoviesController : ApiController
    {
        private ProjectManhattanEntities _db = new ProjectManhattanEntities();

        // GET: api/Movies
        public IQueryable<DTO.Movie> GetMovies()
        {
            return Movie.MovieLsitDto(_db.Movies).AsQueryable();
        }

        // GET: api/Movies/5
        [ResponseType(typeof(MovieComplete))]
        public MovieComplete GetMovieDetail(int id)
        {
            var movie = _db.Movies.First(r => r.MovieID == id);
            var movieDetail = _db.MovieDetails.First(r => r.MovieID == id).MovieDetailDto();
            var criticRatings = _db.CriticRatings.Where(r => r.MovieDetailID == movieDetail.MovieDetailID);
            var userRating = _db.UserRatings.FirstOrDefault(r => r.MovieDetailID == movieDetail.MovieDetailID)?.UserRatingDto();
            var criticsites = criticRatings.Select(criticRating => criticRating.CriticSite);

            return new MovieComplete
            {
                Movie = movie.MovieDto(),
                MovieDetail = movieDetail,
                UserRatings = userRating,
                CriticRatings = CriticRating.CriticRatingLsitDto(criticRatings).ToList(),
                CriticSites = CriticSite.CriticSiteLsitDto(criticsites).ToList()
            };
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
