using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class EmployeeRepository
    {
        public List<IEmployee> Employees { get; set; }
    }
}
