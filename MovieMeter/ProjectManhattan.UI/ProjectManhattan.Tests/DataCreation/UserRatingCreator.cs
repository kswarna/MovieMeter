using System.Collections.Generic;
using ProjectManhattan;

namespace UnitTestProject.Data_Entities
{
    public static class UserRatingCreator
    {
        public static UserRating Create(int id , int movieDetailId, int numOfUsers, decimal rating)
        {
            return new UserRating
            {
                MovieDetailID = movieDetailId,
                NumberOfUsers  =numOfUsers,
                Rating =  rating,
                UserRatingId = id
            };
        }
        public static List<UserRating> CreateUserRating()
        {
            return new List<UserRating>
            {
               SogadeChiniNayana,  NanakuPrematho,Dictator
            };
        }

        #region ReleasedMovies

        private static readonly UserRating SogadeChiniNayana = UserRatingCreator.Create(1, 1,100, (decimal)3.5);

        private static readonly UserRating NanakuPrematho = UserRatingCreator.Create(2, 2, 100, (decimal)4.5);
        private static readonly UserRating Dictator = UserRatingCreator.Create(3, 3,100, (decimal)3.0);
        #endregion

     }
}
