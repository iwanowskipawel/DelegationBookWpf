using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IEmployeeRepository
    {
        IQueryable<IEmployee> Employees { get; }
    }
}