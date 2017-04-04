using System.Collections.Generic;
using System.Linq;

namespace ProjectManhattan
{
    public partial class CriticRating
    {
        public CriticRating Copy()
        {
            return new CriticRating()
            {
                CriticRatingId = CriticRatingId,
                CriticSiteId = CriticSiteId,
                MovieDetailID = MovieDetailID,
                Rating = Rating
            };
        }

        public DTO.CriticRating CriticRatingDto()
        {
            return new DTO.CriticRating()
            {
                CriticRatingId = CriticRatingId,
                CriticSiteId = CriticSiteId,
                MovieDetailID = MovieDetailID,
                Rating = Rating
            };
        }

        public static IEnumerable<DTO.CriticRating> CriticRatingLsitDto(IEnumerable<CriticRating> CriticRatings)
        {
            return CriticRatings.Select(CriticRating => CriticRating.CriticRatingDto());
        }

    }
}