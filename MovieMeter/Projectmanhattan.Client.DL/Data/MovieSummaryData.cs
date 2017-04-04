using ProjectManhattan.DTO.DbTableDTO;
using System.Threading.Tasks;
using System.Collections.Generic;
using MovieMeter.Service;

namespace Projectmanhattan.Client.DL.Data
{
    public class MovieSummaryData : Data<MovieSummaryDTO>
    {
        public override string GetRelativeUrl()
        {
            return UrlResourceFile.MovieSummary;
        }

        public async Task<List<MovieSummaryDTO>> SearchMovies(string searchString)
        {
            var url = UrlResourceFile.BasePath + 
                    string.Format(UrlResourceFile.MovieSummarySeacrh,searchString);
            return await RestService<MovieSummaryDTO>.GetItems(url);
        }
    }
}
