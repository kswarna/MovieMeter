using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using AutoMapper;
using ProjectManhattan.DTO.DbTableDTO;
using ProjectManhattan.Model;

namespace ProjectManhattan.Repository
{
    public class UserRatingRepository : GenericRepository<UserMovieRating, UserMovieRatingtDTO>, IUserRatingRepository
    {
        private static UserRatingRepository _instance;

        public static UserRatingRepository Instance
        {
            get
            {
                return _instance ?? (_instance = new UserRatingRepository());
            }
        }
    }
}
