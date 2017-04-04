using ProjectManhattan.DTO.DbTableDTO;

namespace ProjectManhattan.ViewModel
{
    public class MovieDetailViewModel
    {
        //public MovieComplete MovieComplete { get; set; }
        //public decimal OverallUserRating { get; set; }
        //public decimal OverallCriticRating { get; set; }
        public MovieDetailViewModel(MovieDTO MovieComplete)
        {
            //this.MovieComplete = MovieComplete;
            //if (MovieComplete.UserRatings!=null)
            //{
            //    OverallUserRating = MovieComplete.UserRatings.Rating.Value * 20;
            //}
            //if (MovieComplete.CriticRatings.Count > 0)
            //{
            //    OverallCriticRating = MovieComplete.CriticRatings.Sum(r => r.Rating.Value) * 20 / MovieComplete.CriticRatings.Count;
            //}
        }
    }
}