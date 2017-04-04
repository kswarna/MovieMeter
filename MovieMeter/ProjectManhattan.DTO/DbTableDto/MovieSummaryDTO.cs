using System;
using System.Collections.Generic;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MovieSummaryDTO
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public byte[] SmallPicture { get; set; }
        public byte[] LargePicture { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool HasReleased { get; set; }
        public int LanguageId { get; set; }
        public decimal UserRating { get; set; }
        public decimal CriticRating { get; set; }
        public decimal GuessRating { get; set; }
        public decimal MusicRating { get; set; }
        public List<ArtistDTO> Artist { get; set; }
    }
}
