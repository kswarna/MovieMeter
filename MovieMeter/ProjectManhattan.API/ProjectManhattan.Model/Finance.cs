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
    
    public partial class Finance
    {
        public int FinanceId { get; set; }
        public int MovieId { get; set; }
        public Nullable<double> MovieProductionCost { get; set; }
        public Nullable<int> MovieProductionDuration { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
