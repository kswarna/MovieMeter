using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Repository;
using System.Web.Http;

namespace ProjectManhattan.Controllers.AppController
{
    public class UserRatingController : ApiController
    {
        // GET: UserRating
        public void Post(UserMovieRatingtDTO rating)
        {
            UserRatingRepository.Instance.InsertOrUpdateEntity(-1, rating);
        }
    }
}