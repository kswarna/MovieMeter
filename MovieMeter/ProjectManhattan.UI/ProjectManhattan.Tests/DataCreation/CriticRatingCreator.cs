using System;
using System.Collections.Generic;
using ProjectManhattan;

namespace UnitTestProject.Data_Entities
{
    public static class CriticRatingCreator
    {
        public static CriticRating Create(int id, int criticSiteId, int movieDetailId, decimal rating)
        {
            return new CriticRating
            {
                CriticRatingId = id,
                CriticSiteId = criticSiteId,
                MovieDetailID = movieDetailId,
                Rating = rating
            };
        }
        public static List<CriticRating> CreateCriticRatingsPerMovie(int startId, int movieDetailId, decimal avgrating)
        {
            List<CriticRating> movieCriticRatings = new List<CriticRating>();
            Random rnd1 = new Random();
            for (int criticSiteId = 1; criticSiteId < 10; criticSiteId++)
            {
                var rating = (decimal)(rnd1.Next(-8, 8)*0.125)+avgrating;
                if (rating > (decimal)5.0)
                {
                    rating = (decimal) 5.0;
                }
                else if (rating < (decimal) 0.0)
                {
                    rating = 0;
                }
                movieCriticRatings.Add(Create(startId++, criticSiteId, movieDetailId, rating));
            }
            return movieCriticRatings;
        }
        public static List<CriticRating> CreateCriticRatings()
        {
            var criticRatings = new List<CriticRating>();
            criticRatings.AddRange(SogadeChiniNayana);
            criticRatings.AddRange(NanakuPrematho);
            criticRatings.AddRange(Dictator);
            return criticRatings;
        }


        #region ReleasedMovies
        private static readonly List<CriticRating> SogadeChiniNayana = CreateCriticRatingsPerMovie(1, 1,  (decimal)3.5);
        private static readonly List<CriticRating> NanakuPrematho = CreateCriticRatingsPerMovie(10, 2,  (decimal)4.5);
        private static readonly List<CriticRating> Dictator = CreateCriticRatingsPerMovie(19, 3, (decimal)3.0);
        #endregion
    }
}
