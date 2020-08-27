using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Driver : Employee, IDriver
    {
        public int DriverID { get; set; }
        public List<ICar> UsedCars { get; set; }
    }
}
