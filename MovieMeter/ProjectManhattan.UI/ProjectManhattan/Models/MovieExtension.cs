using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectManhattan
{
    public partial class Movie
    {
        public  Movie Copy(int id)
        {
            return new Movie()
            {
                HasReleased = HasReleased,
                LargePictureUrl = LargePictureUrl,
                LanguageID = LanguageID,
                MovieID = MovieID,
                Name = Name,
                SmallPictureUrl = SmallPictureUrl,
            };
        }

        public DTO.Movie MovieDto()
        {
            return new DTO.Movie()
            {
                HasReleased = HasReleased,
                LargePictureUrl = LargePictureUrl,
                LanguageID = LanguageID,
                MovieID = MovieID,
                Name = Name,
                SmallPictureUrl = SmallPictureUrl,
            };
        }

        public static IEnumerable<DTO.Movie >MovieLsitDto(IEnumerable<Movie> movies )
        {
            return movies.Select(movie => movie.MovieDto());
        }
    }
}