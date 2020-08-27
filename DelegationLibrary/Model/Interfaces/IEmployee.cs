using System.Collections.Generic;

namespace DelegationLibrary.Model
{
    public interface IEmployee
    {
        int EmployeeID { get; set; }
        List<IBusinessTrip> Trips { get; set; }
    }
}