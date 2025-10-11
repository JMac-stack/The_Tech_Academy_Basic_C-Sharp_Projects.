using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class InsureeViewModel // View Model for Admin view.
    {
        public InsureeViewModel(string firstname, string lastname, string emailaddress, decimal quote)
        {
            FirstName = firstname;
            LastName = lastname;
            EmailAddress = emailaddress;
            Quote = quote;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Quote { get; set; }
    }
}