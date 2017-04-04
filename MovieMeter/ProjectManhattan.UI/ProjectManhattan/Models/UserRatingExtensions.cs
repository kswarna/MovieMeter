using System.Collections.Generic;
using System.Linq;

namespace ProjectManhattan
{
    public partial class UserRating
    {
        public UserRating Copy()
        {
            return new UserRating()
            {
                UserRatingId = UserRatingId,
                MovieDetailID = MovieDetailID,
                Rating = Rating,
                NumberOfUsers = NumberOfUsers
            };
        }

        public DTO.UserRating UserRatingDto()
        {
            return new DTO.UserRating()
            {
                UserRatingId = UserRatingId,
                MovieDetailID = MovieDetailID,
                Rating = Rating,
                NumberOfUsers = NumberOfUsers
            };
        }

        public static IEnumerable<DTO.UserRating> MovieLsitDto(List<UserRating> UserRatings)
        {
            return UserRatings.Select(UserRating => UserRating.UserRatingDto());
        }

    }
}