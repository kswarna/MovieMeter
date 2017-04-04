using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public class MovieRepository : GenericRepository<Movie, MovieDTO>, IMovieRepository
    {
        public List<Movie> CachedMovies; 

        public MovieRepository()
        {
            CachedMovies = new List<Movie>();
        }


        public List<MovieSummaryDTO> GetMovies(string searchString = "")
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                var movieSummaries = dbContext.Movies.Where(r => r.Name.Contains(searchString))
                    .Include(m => m.CriticMovieRatings)
                    .Include(m => m.UserMovieRatings)
                    .Include(m => m.MovieArtists)
                    .Include(m => m.MovieArtists.Select(ma => ma.Artist))
                    .ToList();

                return movieSummaries.Select(Mapper.Map<MovieSummaryDTO>).ToList();
            }
        }

        public MovieDetailDTO GetMovieInfo(int movieId)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                var movie = dbContext.Movies.Where(m => m.MovieId == movieId)
                   .Include(m => m.CriticMovieRatings)
                   .Include(m => m.CriticMovieRatings.Select(cm => cm.Critic))
                   .Include(m => m.UserMovieRatings)
                   .Include(m => m.MovieArtists)
                   .Include(m => m.MovieArtists.Select(ma => ma.Artist))
                   .Include(m => m.MovieDistributors)
                   .Include(m => m.MovieDistributors.Select(md => md.Distributor))
                   .FirstOrDefault();
                return movie == null ? null : Mapper.Map<MovieDetailDTO>(movie);
            }
        }

        private static MovieRepository _instance;

        public static MovieRepository Instance
        {
            get
            {
                return _instance ?? (_instance = new MovieRepository());
            }
        }

    }
}
