using Projectmanhattan.Client.DL.Data;
using ProjectManhattan.DTO.DbTableDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManhattan.Client.BL.Pages
{
    public class NowPlayingPage
    {
        MovieDetailData dl = new MovieDetailData();

        public async Task<MovieDetailDTO> GetNowPlayingData(int MovieId)
        {
            var data = await GetData(MovieId);
            return data;
        }
        private async Task<MovieDetailDTO> GetData(int MovieId)
        {
            return await dl.GetData(MovieId);
        }

        public async Task<List<MovieTrailerDTO>> GetMovieTrailerData(int MovieId)
        {
            MovieTrailerData obj = new MovieTrailerData();
            return await obj.GetItemData(MovieId);
        }

    }
}
