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
    
    public partial class AppContract
    {
        public AppContract()
        {
            this.AppXUser = new HashSet<AppXUser>();
            this.contract = new HashSet<contract>();
            this.InformationAditionalXApp = new HashSet<InformationAditionalXApp>();
            this.productXapp = new HashSet<productXapp>();
            this.servicesXapp = new HashSet<servicesXapp>();
        }
    
        public int Id { get; set; }
        public string Description { get; set; }
        public string AppCode { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<AppXUser> AppXUser { get; set; }
        public virtual ICollection<contract> contract { get; set; }
        public virtual ICollection<InformationAditionalXApp> InformationAditionalXApp { get; set; }
        public virtual ICollection<productXapp> productXapp { get; set; }
        public virtual ICollection<servicesXapp> servicesXapp { get; set; }
    }
}
