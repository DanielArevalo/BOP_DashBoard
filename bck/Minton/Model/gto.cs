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
    
    public partial class gto
    {
        public gto()
        {
            this.gtoclaims = new HashSet<gtoclaims>();
        }
    
        public int gto_id { get; set; }
        public int gto_usercreation { get; set; }
        public int contractprod_id { get; set; }
        public int appo_id { get; set; }
    
        public virtual appoiment appoiment { get; set; }
        public virtual contractXproducts contractXproducts { get; set; }
        public virtual ICollection<gtoclaims> gtoclaims { get; set; }
    }
}
