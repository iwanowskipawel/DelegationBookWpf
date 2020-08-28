using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Company : ICompany
    {
        public int CompanyID { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Adres")]
        public IAddress Address { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
