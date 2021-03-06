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
    
    public partial class MovieDetail
    {
        public MovieDetail()
        {
            this.CriticRatings = new HashSet<CriticRating>();
            this.UserRatings = new HashSet<UserRating>();
        }
    
        public int MovieDetailID { get; set; }
        public int MovieID { get; set; }
        public string DetailsUrl { get; set; }
        public string GalleryUrl { get; set; }
        public string TraillerUrl { get; set; }
        public string ScheduleUrl { get; set; }
    
        public virtual ICollection<CriticRating> CriticRatings { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<UserRating> UserRatings { get; set; }
    }
}
