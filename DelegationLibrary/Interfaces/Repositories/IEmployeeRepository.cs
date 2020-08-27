using DelegationLibrary.Model;
using System.Collections.Generic;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IEmployeeRepository
    {
        IEnumerable<IEmployee> Employees { get; }
    }
}