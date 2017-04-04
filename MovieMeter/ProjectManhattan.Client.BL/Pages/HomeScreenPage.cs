using Projectmanhattan.Client.DL.Data;
using ProjectManhattan.DTO.DbTableDTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManhattan.Client.BL.Pages
{
    public class HomeScreenPage
    {
        MovieSummaryData dl = new MovieSummaryData();

        public async Task<List<MovieSummaryDTO>> GetNowPlayingData()
        {
            var data = await GetData();
            return data.Where(r => r.HasReleased).ToList();
            
            
        }

        public async Task<List<MovieSummaryDTO>> GetComingSoonData()
        {
            var data = await GetData();
          
            return data.Where(r => !r.HasReleased).ToList();
           
        }

        public async Task<List<MovieSummaryDTO>> GetMovies()
        {
            var data = await GetData();
            return data;
        }

        private async Task<List<MovieSummaryDTO>> GetData()
        {
            return await dl.GetData();
        }

        public async Task<List<MovieSummaryDTO>> SearchMovies(string searchString)
        {

            var movies = await dl.SearchMovies(searchString);
            return movies;
        }
    }
}
