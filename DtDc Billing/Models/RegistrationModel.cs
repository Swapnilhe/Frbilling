using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DtDc_Billing.Models
{
    public class RegistrationModel
    {
        [Required]
        public string Pfcode { get; set; }
        [Required]
        public string franchiseName { get; set; }
        [Required]
        [MaxLength(50)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string emailId { get; set; }
        public Nullable<System.DateTime> dateTime { get; set; }
        [Required]
        public string ownerName { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        [Compare("password")]
        public string confirmPassword { get; set; }

        public Nullable<bool> isPaid { get; set; }

        [Required]
        public string mobileNo { get; set; }
        [Required]
        public string address { get; set; }

        public string referralCode { get; set; }
        public string referralby { get; set; }


    }
}