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
    
    public partial class languages
    {
        public languages()
        {
            this.users = new HashSet<users>();
        }
    
        public int lang_id { get; set; }
        public string lang_description { get; set; }
        public string lang_short { get; set; }
    
        public virtual ICollection<users> users { get; set; }
    }
}
