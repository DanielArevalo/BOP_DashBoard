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
    
    public partial class glosaXtreatments
    {
        public int glotreat_id { get; set; }
        public string glotreat_characteristic { get; set; }
        public int glosa_id { get; set; }
        public int treat_id { get; set; }
    
        public virtual glosas glosas { get; set; }
        public virtual treatments treatments { get; set; }
    }
}
