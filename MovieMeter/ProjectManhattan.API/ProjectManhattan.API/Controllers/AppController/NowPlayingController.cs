using System.Web.Http;
using ProjectManhattan.Repository;
using ProjectManhattan.DTO.DbTableDTO;


namespace ProjectManhattan.Controllers.AppController
{
    public class NowPlayingController : ApiController
    {
        public MovieDetailDTO GetMovieInfo( int movieId)
        {
            var movieInfo = MovieRepository.Instance.GetMovieInfo(movieId);
            return movieInfo;

        }
    }
}
