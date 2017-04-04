namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MovieArtistDTO
    {
        public int MovieArtistId { get; set; }
        public int MovieId { get; set; }
        public int ArtistId { get; set; }
        public ArtistDTO Artist { get; set; }
    }
}
