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
    
    public partial class contract
    {
        public contract()
        {
            this.contractXproducts = new HashSet<contractXproducts>();
            this.entitycontract = new HashSet<entitycontract>();
            this.contractXproducts1 = new HashSet<contractXproducts>();
            this.providerXcontract = new HashSet<providerXcontract>();
        }
    
        public int contract_id { get; set; }
        public string contract_description { get; set; }
        public Nullable<int> IdAppContract { get; set; }
    
        public virtual AppContract AppContract { get; set; }
        public virtual ICollection<contractXproducts> contractXproducts { get; set; }
        public virtual ICollection<entitycontract> entitycontract { get; set; }
        public virtual ICollection<contractXproducts> contractXproducts1 { get; set; }
        public virtual ICollection<providerXcontract> providerXcontract { get; set; }
    }
}