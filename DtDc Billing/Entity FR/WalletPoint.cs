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
    
    public partial class WalletPoint
    {
        public long Wallet_Id { get; set; }
        public string MobileNo { get; set; }
        public Nullable<float> Wallet_Money { get; set; }
        public Nullable<System.DateTime> Datetime_Wa { get; set; }
        public Nullable<double> Redeemed { get; set; }
        public string Name { get; set; }

        public string PFCode { get; set; }
    }
}
