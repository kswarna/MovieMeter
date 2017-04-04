using ProjectManhattan.DTO.DbTableDTO;

namespace Projectmanhattan.Client.DL.Data
{
    public class MovieTrailerData : Data<MovieTrailerDTO>
    {
        public override string GetRelativeUrl()
        {
            return string.Format(UrlResourceFile.MovieTrailer, ItemId);
        }
    }
}