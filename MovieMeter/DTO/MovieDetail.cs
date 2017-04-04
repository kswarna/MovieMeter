using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class MovieDetail
    {
        [DataMember]
        public int MovieDetailID { get; set; }
        [DataMember]
        public int MovieID { get; set; }
        [DataMember]
        public string DetailsUrl { get; set; }
        [DataMember]
        public string GalleryUrl { get; set; }
        [DataMember]
        public string TraillerUrl { get; set; }
        [DataMember]
        public string ScheduleUrl { get; set; }

    }
}