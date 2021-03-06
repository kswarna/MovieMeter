//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLoader
{
    using System;
    using System.Collections.Generic;
    
    public partial class Movie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Movie()
        {
            this.MovieDetails = new HashSet<MovieDetail>();
        }
    
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string SmallPictureUrl { get; set; }
        public string LargePictureUrl { get; set; }
        public string HasReleased { get; set; }
        public int LanguageID { get; set; }
    
        public virtual Language Language { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MovieDetail> MovieDetails { get; set; }
    }
}
