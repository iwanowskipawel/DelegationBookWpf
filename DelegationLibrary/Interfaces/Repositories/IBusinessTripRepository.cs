using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IBusinessTripRepository
    {
        IQueryable<IBusinessTrip> BusinessTrip { get; }
    }
}