//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManhattan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Theatre
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Theatre()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }
        public Nullable<double> TheatreLatitude { get; set; }
        public Nullable<double> TheatreLongitude { get; set; }
        public int NumberOfScreens { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
