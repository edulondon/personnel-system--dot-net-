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
    
    public partial class issuedQuery
    {
        public int Id { get; set; }
        public string staffId { get; set; }
        public string queryBody { get; set; }
        public string status { get; set; }
        public System.DateTime dateIssued { get; set; }
    
        public virtual staffRecord staffRecord { get; set; }
    }
}
