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
    
    public partial class apps
    {
        public apps()
        {
            this.menus = new HashSet<menus>();
            this.usertypeXapp = new HashSet<usertypeXapp>();
        }
    
        public int app_id { get; set; }
        public string app_name { get; set; }
    
        public virtual ICollection<menus> menus { get; set; }
        public virtual ICollection<usertypeXapp> usertypeXapp { get; set; }
    }
}
