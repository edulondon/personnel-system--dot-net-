//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace niaps_ver_1._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class state
    {
        public state()
        {
            this.LGAs = new HashSet<LGA>();
        }
    
        public string stateCode { get; set; }
        public string state1 { get; set; }
    
        public virtual ICollection<LGA> LGAs { get; set; }
    }
}
