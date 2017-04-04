using System.Collections.Generic;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public interface IMovieRepository : IRepository<Movie, MovieDTO>
    {
        MovieDetailDTO GetMovieInfo(int movieId);
        List<MovieSummaryDTO> GetMovies(string searchString = "");
    }
}