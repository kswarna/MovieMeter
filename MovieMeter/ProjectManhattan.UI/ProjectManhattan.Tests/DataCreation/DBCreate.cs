using UnitTestProject.Data_Entities;

namespace ProjectManhattan.Tests.DataCreation
{
    public class DbCreate
    {
        private ProjectManhattanEntities _db = new ProjectManhattanEntities();

        public void CreateNewDb()
        {
            foreach (var language in LangaugeCreator.GetAll())
            {
                _db.Languages.Add(language);
            }
            foreach (var sites in WebSiteCreator.GetAllCriticSites())
            {
                _db.CriticSites.Add(sites);
            }
            foreach (var movie in MovieCreator.CreateMovies())
            {
                _db.Movies.Add(movie);
            }
            foreach (var movieDetail in MovieDetailCreator.CreateMovies())
            {
                _db.MovieDetails.Add(movieDetail);
            }

            foreach (var criticRating in CriticRatingCreator.CreateCriticRatings())
            {
                _db.CriticRatings.Add(criticRating);
            }

            foreach (var userRating in UserRatingCreator.CreateUserRating())
            {
                _db.UserRatings.Add(userRating);
            }

            _db.SaveChanges();
        }
    }
}
