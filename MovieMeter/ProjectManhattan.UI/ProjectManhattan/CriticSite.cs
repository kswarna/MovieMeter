//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManhattan
{
    using System;
    using System.Collections.Generic;
    
    public partial class CriticSite
    {
        public CriticSite()
        {
            this.CriticRatings = new HashSet<CriticRating>();
        }
    
        public int CriticSiteId { get; set; }
        public string SiteName { get; set; }
        public string WebUrl { get; set; }
        public Nullable<int> AlexaRating { get; set; }
    
        public virtual ICollection<CriticRating> CriticRatings { get; set; }
    }
}
