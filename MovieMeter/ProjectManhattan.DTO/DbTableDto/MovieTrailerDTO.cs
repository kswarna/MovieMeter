using System.Collections.Generic;

namespace ProjectManhattan.DTO.DbTableDTO
{
    public class MovieTrailerDTO
    {
        public int MovieTrailerId { get; set; }
        public int MovieId { get; set; }
        public MovieDTO Movie { get; set; }
        public string TrailerPath { get; set; }
        public int TrailerType { get; set; }
        
    }
}