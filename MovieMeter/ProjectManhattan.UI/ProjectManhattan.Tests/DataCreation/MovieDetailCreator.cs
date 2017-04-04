using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManhattan;

namespace UnitTestProject.Data_Entities
{
    public static class MovieDetailCreator
    {
        public static List<MovieDetail> CreateMovies()
        {
            return new List<MovieDetail>
            {
               SogadeChiniNayana,  NanakuPrematho,Dictator,SaahasamSwaasagaSaagipo,Krishnashtami,Oopiri
            };
        }
        public static MovieDetail GetMovieDetail(string detailsUrl, string galleryUrl, int movieDetailId,
         int movieId, string scheduleurl, string trailerUrl)
        {
            return new MovieDetail
            {
                DetailsUrl = detailsUrl,
                GalleryUrl = galleryUrl,
                MovieDetailID = movieDetailId,
                MovieID = movieId,
                ScheduleUrl = scheduleurl,
                TraillerUrl = trailerUrl
            };
        }
        #region ReleasedMovies

        private static readonly MovieDetail SogadeChiniNayana =
            GetMovieDetail("https://en.wikipedia.org/wiki/Soggade_Chinni_Nayana",
                "https://www.google.com/search?q=soggade+chinni+nayana&tbm=isch",
                1,
                1,
                "https://www.google.com/search?q=soggade+chinni+nayana",
                "https://www.youtube.com/watch?v=2NldCk-YzuU"
                );

        private static readonly MovieDetail NanakuPrematho =
            GetMovieDetail("https://en.wikipedia.org/wiki/Nannaku_Prematho",
                "https://www.google.com/search?q=nannaku+prematho&tbm=isch",
                2,
                2,
                "https://www.google.com/search?q=nannaku+prematho",
                "https://www.youtube.com/watch?v=Om69gF1iiT4"
                );
        private static readonly MovieDetail Dictator =
            GetMovieDetail("https://en.wikipedia.org/wiki/Dictator_(2016_film)",
                "https://www.google.com/search?q=dictator+telugu+movie&tbm=isch",
                3,
                3,
                "https://www.google.com/search?q=dictator+telugu+movie",
                "https://www.youtube.com/watch?v=zTMVMdCseRM"
                );
        #endregion

        #region ComingSoon
        private static readonly MovieDetail SaahasamSwaasagaSaagipo =
       GetMovieDetail("https://en.wikipedia.org/wiki/Sahasam_Swasaga_Sagipo",
           "https://www.google.com/search?q=Sahasam+Swasaga+Sagipo&tbm=isch",
           4,
           4,
           "https://www.google.com/search?q=Sahasam+Swasaga+Sagipo",
           "https://www.youtube.com/watch?v=UBMFlQM8has"
           );

        private static readonly MovieDetail Krishnashtami =
            GetMovieDetail("http://www.filmibeat.com/telugu/movies/krishnashtami.html",
                "https://www.google.com/search?q=krishnashtami+telugu+movie&tbm=isch",
                5,
                5,
                "https://www.google.com/search?q=krishnashtami+telugu+movie",
                "https://www.youtube.com/watch?v=PHtXp5g-aRE"
                );
        private static readonly MovieDetail Oopiri =
            GetMovieDetail("https://en.wikipedia.org/wiki/Oopiri",
                "https://www.google.com/search?q=oopiri&tbm=isch",
                6,
                6,
                "https://www.google.com/search?q=oopiri",
                "https://www.youtube.com/watch?v=iMA4ZkicDeg"
                );
        #endregion
    }
}
