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
    
    public partial class impuestoXcountry
    {
        public int impucoun_id { get; set; }
        public Nullable<int> country_id { get; set; }
        public Nullable<int> impu_id { get; set; }
        public Nullable<bool> status { get; set; }
    
        public virtual country country { get; set; }
        public virtual impuesto impuesto { get; set; }
    }
}
