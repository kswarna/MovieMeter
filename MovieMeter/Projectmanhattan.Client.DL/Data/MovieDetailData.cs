using ProjectManhattan.DTO.DbTableDTO;

namespace Projectmanhattan.Client.DL.Data
{
    public class MovieDetailData : Data<MovieDetailDTO>
    {
        public override string GetRelativeUrl()
        {
            return string.Format(UrlResourceFile.MovieDetail,ItemId);
        }
    }
}
