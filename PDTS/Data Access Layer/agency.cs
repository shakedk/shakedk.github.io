//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDTS.Data_Access_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class agency
    {
        public agency()
        {
            this.routesInfoes = new HashSet<routesInfo>();
        }
    
        public int agency_id { get; set; }
        public string agency_url { get; set; }
        public string agency_timezone { get; set; }
        public string agency_lang { get; set; }
    
        public virtual ICollection<routesInfo> routesInfoes { get; set; }
    }
}