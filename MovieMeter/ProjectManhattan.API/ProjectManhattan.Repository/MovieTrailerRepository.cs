using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;
using AutoMapper;

namespace ProjectManhattan.Repository
{
    public class MovieTrailerRepository : GenericRepository<MovieTrailer, MovieTrailerDTO>, IMovieTrailerRepository
    {
        public MovieTrailerDTO GetMovieTrailer(int id)
        {
            using (var dbContext = new ProjectManhattanEntities())
            {
                MovieTrailer movieTrailer = dbContext.MovieTrailers
                    .Where(m => m.MovieTrailerId == id)
                    .Include(m => m.Movie)
                    .FirstOrDefault();
                if (movieTrailer != null)
                {
                    var movieTrailerDTO = Mapper.Map<MovieTrailerDTO>(movieTrailer);
                    return movieTrailerDTO;
                }
                return null;
            }
        }

        public List<MovieTrailerDTO> GetMovieTrailers(int movieId)
        {
            List<MovieTrailerDTO> movieTrailerDtos;

            using (var dbContext = new ProjectManhattanEntities())
            {
                var movieTrailers = dbContext.MovieTrailers
                    .Where(m => m.MovieId == movieId)
                    .Include(m => m.Movie).ToList();

                movieTrailerDtos = movieTrailers.Select(Mapper.Map<MovieTrailerDTO>).ToList();
            }

            return movieTrailerDtos;
        }

        public List<MovieTrailerDTO> GetMovieTrailers()
        {
            List<MovieTrailerDTO> movieTrailerDtos;

            using (var dbContext = new ProjectManhattanEntities())
            {
                var movieTrailers = dbContext.MovieTrailers
                    .Take(100)
                    .Include(m => m.Movie).ToList();

                movieTrailerDtos = movieTrailers.Select(Mapper.Map<MovieTrailerDTO>).ToList();
            }

            return movieTrailerDtos;
        }
    }
}