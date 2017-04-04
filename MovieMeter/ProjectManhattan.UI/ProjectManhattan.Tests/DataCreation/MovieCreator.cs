using System.Collections.Generic;
using System.Security.AccessControl;
using ProjectManhattan.Helpers;
using ProjectManhattan;

namespace UnitTestProject.Data_Entities
{
    public static class MovieCreator
    {
        public static List<Movie> CreateMovies()
        {
            return new List<Movie>
            {
               SogadeChiniNayana,  NanakuPrematho,Dictator,SaahasamSwaasagaSaagipo,Krishnashtami,Oopiri
            };
        }



        public static Movie GetMovie(string hasReleased, string largePictureUrl, string smallPictureUrl, string name, int movieId, int languageId)
        {
            Movie movie = new Movie()
            {
                HasReleased = hasReleased,
                LargePictureUrl = largePictureUrl,
                LanguageID = languageId,
                MovieID = movieId,
                Name = name,
                SmallPictureUrl = smallPictureUrl,
            };
            return movie;
        }
        #region ReleasedMovies
        private static readonly Movie SogadeChiniNayana = new Movie()
        {
            HasReleased = MovieHasReleasedEnum.Released.ToString(),
            LargePictureUrl = "https://i.ytimg.com/vi/xermlS4ZwUg/maxresdefault.jpg" ,
            LanguageID = 1,
            MovieID = 1,
            Name = "Soggade Chinni Nayana",
            SmallPictureUrl = "http://img.nowrunning.com/content/movie/2015/SCN/stills/Soggade-Chinni-Nayana-1.jpg",
        };

        private static readonly Movie NanakuPrematho = new Movie()
        {
            HasReleased = MovieHasReleasedEnum.Released.ToString(),
            LargePictureUrl = "https://i.ytimg.com/vi/1W1hABhzEtU/maxresdefault.jpg",
            LanguageID = 1,
            MovieID = 2,
            Name = "Nanaku Prematho",
            SmallPictureUrl = "http://i0.wp.com/www.newsonway.com/wp-content/uploads/2015/09/ntr.jpg?resize=800%2C445",
        };

        private static readonly Movie Dictator = new Movie()
        {
            HasReleased = MovieHasReleasedEnum.Released.ToString(),
            LargePictureUrl = "http://www.belvoireagle.com/wp-content/uploads/2015/11/Dictator-Movie-Poster.png",
            LanguageID = 1,
            MovieID = 3,
            Name = "Dictator",
            SmallPictureUrl = "http://i0.wp.com/www.newsonway.com/wp-content/uploads/2015/09/ntr.jpg?resize=800%2C445",
        };
        #endregion

        #region ComingSoon
        private static readonly Movie SaahasamSwaasagaSaagipo = new Movie()
        {
            HasReleased = MovieHasReleasedEnum.ComingSoon.ToString(),
            LargePictureUrl = "https://i.ytimg.com/vi/-Nri2syXxzA/maxresdefault.jpg",
            LanguageID = 1,
            MovieID = 4,
            Name = "Saahasam Swaasaga Saagipo",
            SmallPictureUrl = "http://www.filmibeat.com/img/220x80x275/popcorn/movie_posters/saahasam-swaasaga-saagipo-20150902122040-14639.jpg",
        };

        private static readonly Movie Krishnashtami = new Movie()
        {
            HasReleased = MovieHasReleasedEnum.ComingSoon.ToString(),
            LargePictureUrl = "https://i.ytimg.com/vi/h9bZbNLIW7k/maxresdefault.jpg",
            LanguageID = 1,
            MovieID = 5,
            Name = "Krishnashtami",
            SmallPictureUrl = "http://www.filmibeat.com/img/220x80x275/popcorn/movie_posters/krishnashtami-20150817102257-14600.jpg",
        };

        private static readonly Movie Oopiri = new Movie()
        {
            HasReleased = MovieHasReleasedEnum.ComingSoon.ToString(),
            LargePictureUrl = "http://photos.filmibeat.com/ph-big/2015/09/nagarjuna-karthi_144264215600.jpg",
            LanguageID = 1,
            MovieID = 6,
            Name = "Oopiri",
            SmallPictureUrl = "http://www.filmibeat.com/img/220x80x275/popcorn/movie_posters/oopiri-20150918142004-14664.jpg",
        };
        #endregion
    }
}
