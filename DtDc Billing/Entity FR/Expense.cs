//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DtDc_Billing.Entity_FR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expense
    {
        public long Exp_ID { get; set; }
        public Nullable<float> Amount { get; set; }
        public string Rason { get; set; }
        public string Category { get; set; }
        public string Pf_Code { get; set; }
        public Nullable<System.DateTime> Datetime_Exp { get; set; }
        public Nullable<long> User_Id { get; set; }
    
        public virtual User User { get; set; }
        public virtual Franchisee Franchisee { get; set; }
    }
}