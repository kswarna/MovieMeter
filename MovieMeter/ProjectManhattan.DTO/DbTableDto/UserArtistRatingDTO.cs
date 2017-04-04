using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class UserArtistRatingDTO
    {
        public int UserArtistRatingId { get; set; }
        public int UserId { get; set; }
        public int MovieArtistId { get; set; }
        public decimal? Rating { get; set; }
        public string ReviewDescription { get; set; }
        public int? ReviewTypeId { get; set; }
        public DateTime RatingDate { get; set; }

    }
}
