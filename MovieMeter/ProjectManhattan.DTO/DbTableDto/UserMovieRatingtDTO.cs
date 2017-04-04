using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class UserMovieRatingtDTO
    {
        public int UserMovieCommentId { get; set; }
        public int UserId { get; set; }
        public int MovieId { get; set; }
        public decimal? Rating { get; set; }
        public string ReviewDescription { get; set; }
        public int? ReviewTypeId { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
