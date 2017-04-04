using System.Runtime.Serialization;

namespace DTO
{
    [DataContract]
    public class CriticSite
    {
        [DataMember]
        public int CriticSiteId { get; set; }
        [DataMember]
        public string SiteName { get; set; }
        [DataMember]
        public string WebUrl { get; set; }
        [DataMember]
        public int? AlexaRating { get; set; }

    }
}