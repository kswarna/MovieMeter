using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class Movie
    {
        [DataMember]
        public int MovieID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string SmallPictureUrl { get; set; }
        [DataMember]
        public string LargePictureUrl { get; set; }
        [DataMember]
        public string HasReleased { get; set; }
        [DataMember]
        public int LanguageID { get; set; }
    }
}
