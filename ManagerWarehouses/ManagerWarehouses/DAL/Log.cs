//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerWarehouses.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Log
    {
        public long Log_ID { get; set; }
        public long Shoes_ID { get; set; }
        public int Amout { get; set; }
        public string Action { get; set; }
        public long Action_By { get; set; }
        public string Action_Date { get; set; }
        public string Note { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual Shoes Shoes { get; set; }
    }
}
