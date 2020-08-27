using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.Model
{
    public class Employee : Person, IEmployee
    {
        public int EmployeeID { get; set; }
        public List<IBusinessTrip> Trips { get; set; }
    }
}
