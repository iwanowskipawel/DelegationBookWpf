using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DelegationLibrary.Model
{
    [Serializable]
    public class Driver : Employee, IDriver
    {
        [Display(Name = "DriverID")]
        public int DriverID { get; set; }

        [Display(Name = "Użytkowane samochody")]
        public List<ICar> UsedCars { get; set; }
    }
}
