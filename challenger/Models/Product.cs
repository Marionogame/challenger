//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace challenger.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string ProductionStatus { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
