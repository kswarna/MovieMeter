
using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
   public  class CriticRatingDTO
    {
        public int CriticMovieRatingId { get; set; }
        public string SiteName { get; set; }
        public string WebUrl { get; set; }
        public decimal? Rating { get; set; }
        public DateTime RatingDate { get; set; }       
    }
}
