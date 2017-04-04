using System.Collections.Generic;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MoviePhotoDTO
    {
        public int MoviePhotoId { get; set; }
        public int MovieId { get; set; }
        public MovieDTO Movie { get; set; }
        public string MoviePhotoURL { get; set; }
        
        public List<MoviePhotoArtistDTO> MoviePhotoArtists { get; set; }
    }
}