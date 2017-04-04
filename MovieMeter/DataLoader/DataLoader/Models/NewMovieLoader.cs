using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLoader.Models
{
    public class NewMovieLoader
    {
        public MovieLoader Movie { get; set; }
        public MovieDetailLoader MovieDetail { get; set; }
        public UserRatingLoader UserRating { get; set; }
        public List<CriticRatingLoader> CriticRatings { get; set; }

        public NewMovieLoader()
        {
            Movie = new MovieLoader();
            MovieDetail = new MovieDetailLoader() { MovieLoader = Movie };
            UserRating = new UserRatingLoader() { MovieDetailLoader = MovieDetail };
            CriticRatings = new List<CriticRatingLoader>();
//            foreach
        }
    }
}