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
    
    public partial class permissionsXmenu
    {
        public int permimenu_id { get; set; }
        public int menu_id { get; set; }
        public Nullable<int> utapp_id { get; set; }
    
        public virtual menus menus { get; set; }
        public virtual usertypeXapp usertypeXapp { get; set; }
    }
}
