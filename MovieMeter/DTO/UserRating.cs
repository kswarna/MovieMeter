using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class UserRating
    {
        [DataMember]
        public int UserRatingId { get; set; }
        [DataMember]
        public int MovieDetailID { get; set; }
        [DataMember]
        public decimal? Rating { get; set; }
        [DataMember]
        public int NumberOfUsers { get; set; }
    }
}