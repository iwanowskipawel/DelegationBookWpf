using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Employee : Person
    {
        public int EmployeeID { get; set; }
        public List<BusinessTrip> Trips { get; set; }
    }
}
