using System;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class ArtistDTO
    {
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public ArtistTypeDTO ArtistType { get; set; }
        public DateTime? ArtistDOB { get; set; }
        public string ArtistTitle { get; set; }
        public string ArtistNickName { get; set; }

    }
}
