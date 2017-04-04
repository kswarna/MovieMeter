using System.Collections.Generic;
using System.Web.Http;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Repository;

namespace ProjectManhattan.Controllers.AppController
{
    public class TrailersController : ApiController
    {
        private readonly IMovieTrailerRepository _movieTrailerRepository = new MovieTrailerRepository();

        //public IEnumerable<MovieTrailerDTO> Get()
        //{
        //    return _movieTrailerRepository.GetMovieTrailers();
        //}

        public List<MovieTrailerDTO> GetTrailers(int movieId)
        {
            return _movieTrailerRepository.GetMovieTrailers(movieId);
        }

        //public MovieTrailerDTO GetTrailer(int id)
        //{
        //    return _movieTrailerRepository.GetMovieTrailer(id);
        //} 
    }
}
