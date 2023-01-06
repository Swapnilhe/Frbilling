using DtDc_Billing.Entity_FR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DtDc_Billing.Models
{
    public class CashCounterPaymentModel
    {

        public long Pay_ID { get; set; }
        public string Consignment_No { get; set; }
        public Nullable<float> amount { get; set; }
        public string Pf_Code { get; set; }
        public string Description_ { get; set; }
        public Nullable<System.DateTime> Datetime_Pay { get; set; }
        public Nullable<long> User_Id { get; set; }

        public virtual User User { get; set; }
        public virtual Franchisee Franchisee { get; set; }
    }
}