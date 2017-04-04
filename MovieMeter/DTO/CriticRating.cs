using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class CriticRating
    {
        [DataMember]
        public int CriticRatingId { get; set; }
        [DataMember]
        public int? CriticSiteId { get; set; }
        [DataMember]
        public int MovieDetailID { get; set; }
        [DataMember]
        public decimal? Rating { get; set; }
    }
}