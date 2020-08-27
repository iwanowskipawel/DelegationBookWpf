using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Company : ICompany
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public IAddress Address { get; set; }
    }
}
