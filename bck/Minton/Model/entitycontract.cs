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
    
    public partial class entitycontract
    {
        public int enticontra_id { get; set; }
        public int contract_id { get; set; }
        public int enti_id { get; set; }
    
        public virtual contract contract { get; set; }
        public virtual entity entity { get; set; }
    }
}
