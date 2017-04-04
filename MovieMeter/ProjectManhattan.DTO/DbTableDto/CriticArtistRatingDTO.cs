using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class CriticArtistRatingDTO
    {
        public int CriticArtistRatingId { get; set; }
        public int CriticId { get; set; }
        public int MovieArtistId { get; set; }
        public decimal? Rating { get; set; }
        public string ReviewDescription { get; set; }
        public int? ReviewTypeId { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
