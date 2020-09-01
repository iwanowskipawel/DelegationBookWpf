using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Employee : Person, IEmployee
    {
        [Display(Name = "EmployeeID")]
        public int EmployeeID { get; set; }

        [Display(Name = "Wyjazdy")]
        public List<IBusinessTrip> Trips { get; set; }

    }
}
