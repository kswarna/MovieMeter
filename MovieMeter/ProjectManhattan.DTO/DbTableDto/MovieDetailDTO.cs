using System.Collections.Generic;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MovieDetailDTO
    {
        public MovieDTO Movie { get; set; }
        public List<CriticRatingDTO> CriticRatings { get; set; }
        public List<UserMovieRatingtDTO> UserRatings { get; set; }
        public List<DistributorDTO> Distributors { get; set; }
        public List<ArtistDTO> Artist { get; set; }
    }
}
