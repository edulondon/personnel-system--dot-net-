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
    
    public partial class LGA
    {
        public int LGACode { get; set; }
        public string stateCode { get; set; }
        public string name { get; set; }
    
        public virtual state state { get; set; }
    }
}
