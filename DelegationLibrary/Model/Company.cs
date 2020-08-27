using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
