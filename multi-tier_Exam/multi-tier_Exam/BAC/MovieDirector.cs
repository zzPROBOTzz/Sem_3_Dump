//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace multi_tier_Exam.BAC
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovieDirector
    {
        public int AssignID { get; set; }
        public Nullable<int> MovieID { get; set; }
        public Nullable<int> DirectorID { get; set; }
    
        public virtual Director Director { get; set; }
        public virtual Movy Movy { get; set; }
    }
}
