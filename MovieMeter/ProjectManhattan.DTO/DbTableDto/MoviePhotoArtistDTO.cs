namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MoviePhotoArtistDTO
    {
        public int MoviePhotoArtistId { get; set; }
        public int MoviePhotoId { get; set; }
        public int ArtistId { get; set; }

        public ArtistDTO ArtistDTO { get; set; }
    }
}