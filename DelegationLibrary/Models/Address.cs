using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Address : IAddress
    {
        [Display(Name = "AddressID")]
        public int AddressID { get; set; }

        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Display(Name = "Numer")]
        public string Number { get; set; }

        [Display(Name = "Miejscowość")]
        public string City { get; set; }

        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }

        public override string ToString()
        {
            return $"{ Street } { Number }, { PostalCode } { City }";
        }
    }
}
