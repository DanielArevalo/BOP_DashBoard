//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Milton.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class application_area
    {
        public application_area()
        {
            this.characteristic_treatment = new HashSet<characteristic_treatment>();
        }
    
        public int apparea_id { get; set; }
        public string apparea_description { get; set; }
    
        public virtual ICollection<characteristic_treatment> characteristic_treatment { get; set; }
    }
}