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
    
    public partial class user
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string username { get; set; }
        public string staffId { get; set; }
    
        public virtual staffRecord staffRecord { get; set; }
    }
}
