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
    
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string BlogURL { get; set; }
        public string FacebookId { get; set; }
        public string TwitterId { get; set; }
        public Nullable<int> LanguageId { get; set; }
    
        public virtual Language Language { get; set; }
    }
}