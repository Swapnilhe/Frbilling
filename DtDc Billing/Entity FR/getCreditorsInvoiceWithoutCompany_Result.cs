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
    
    public partial class getCreditorsInvoiceWithoutCompany_Result
    {
        public Nullable<System.DateTime> invoicedate { get; set; }
        public string invoiceno { get; set; }
        public Nullable<System.DateTime> periodfrom { get; set; }
        public Nullable<System.DateTime> periodto { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> fullsurchargetax { get; set; }
        public Nullable<double> fullsurchargetaxtotal { get; set; }
        public Nullable<double> servicetax { get; set; }
        public Nullable<double> servicetaxtotal { get; set; }
        public string Customer_Id { get; set; }
        public Nullable<double> netamount { get; set; }
        public Nullable<double> paid { get; set; }
    }
}
