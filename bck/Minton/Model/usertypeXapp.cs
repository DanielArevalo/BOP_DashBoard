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
    
    public partial class usertypeXapp
    {
        public usertypeXapp()
        {
            this.permissionsXmenu = new HashSet<permissionsXmenu>();
        }
    
        public int utapp_id { get; set; }
        public int utype_id { get; set; }
        public int app_id { get; set; }
    
        public virtual apps apps { get; set; }
        public virtual ICollection<permissionsXmenu> permissionsXmenu { get; set; }
        public virtual roles roles { get; set; }
    }
}
