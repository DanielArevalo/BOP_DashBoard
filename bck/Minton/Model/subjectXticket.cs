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
    
    public partial class subjectXticket
    {
        public subjectXticket()
        {
            this.ticket = new HashSet<ticket>();
        }
    
        public int subjtick_id { get; set; }
        public string subjtick_description { get; set; }
    
        public virtual ICollection<ticket> ticket { get; set; }
    }
}
