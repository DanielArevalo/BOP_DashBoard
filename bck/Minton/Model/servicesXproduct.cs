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
    
    public partial class servicesXproduct
    {
        public int id { get; set; }
        public Nullable<int> idService { get; set; }
        public Nullable<int> idProduct { get; set; }
    
        public virtual products products { get; set; }
        public virtual services services { get; set; }
    }
}
