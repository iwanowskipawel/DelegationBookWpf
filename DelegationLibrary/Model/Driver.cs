using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Driver : Employee
    {
        public int DriverID { get; set; }
        public List<Car> UsedCars { get; set; }
    }
}
