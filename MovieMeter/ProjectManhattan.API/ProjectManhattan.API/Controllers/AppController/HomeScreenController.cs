using System.Collections.Generic;
using System.Web.Http;
using ProjectManhattan.Repository;
using ProjectManhattan.DTO.DbTableDTO;

namespace ProjectManhattan.Controllers.AppController
{
    public class HomeScreenController : ApiController
    {
        public List<MovieSummaryDTO> GetMovies()
        {
            var allMovies = MovieRepository.Instance.GetMovies();
            return allMovies;
        }

        public List<MovieSummaryDTO> GetMovies(string searchString)
        {
            var allMovies = MovieRepository.Instance.GetMovies(searchString);
            return allMovies;
        }

    }
}
