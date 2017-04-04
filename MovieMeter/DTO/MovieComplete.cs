using System.Collections.Generic;

namespace DTO
{
    public class MovieComplete
    {
        public Movie Movie { get; set; }
        public MovieDetail MovieDetail { get; set; }

        public List<CriticSite> CriticSites { get; set; }
        public List<CriticRating> CriticRatings { get; set; }
        public UserRating UserRatings { get; set; }
    }
}
