using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public abstract class Person
    {
        [Display(Name = "PersonID")]
        public int PersonID { get; set; }

        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Pełne nazwisko")]
        public string FullName => $"{ FirstName } { LastName }";

        public override string ToString()
        {
            return FullName;
        }
    }
}
