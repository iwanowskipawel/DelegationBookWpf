using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IDriverRepository
    {
        IQueryable<IDriver> Drivers { get; }
    }
}