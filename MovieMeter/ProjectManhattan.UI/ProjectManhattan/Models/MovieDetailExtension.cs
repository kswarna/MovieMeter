using System.Collections.Generic;
using System.Linq;

namespace ProjectManhattan
{
    public partial class MovieDetail
    {
        public MovieDetail Copy(int id)
        {
            return new MovieDetail()
            {
                MovieDetailID = MovieDetailID,
                MovieID = MovieID,
                DetailsUrl = DetailsUrl,
                GalleryUrl = GalleryUrl,
                TraillerUrl = TraillerUrl,
                ScheduleUrl = ScheduleUrl
            };
        }

        public DTO.MovieDetail MovieDetailDto()
        {
            return new DTO.MovieDetail()
            {
                MovieDetailID = MovieDetailID,
                MovieID = MovieID,
                DetailsUrl = DetailsUrl,
                GalleryUrl = GalleryUrl,
                TraillerUrl = TraillerUrl,
                ScheduleUrl = ScheduleUrl
            };
        }

        public static IEnumerable<DTO.MovieDetail> MovieDetailLsitDto(List<MovieDetail> movies)
        {
            return movies.Select(movie => movie.MovieDetailDto());
        }
    }
}