using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class CriticMovieRatingDTO
    {
        public int CriticMovieRatingId { get; set; }
        public int CriticId { get; set; }
        public int MovieId { get; set; }
        public decimal? Rating { get; set; }
        public string ReviewDescription { get; set; }
        public int? ReviewTypeId { get; set; }
        public DateTime RatingDate { get; set; }

        public CriticDTO CriticDTO { get; set; }
    }
}
