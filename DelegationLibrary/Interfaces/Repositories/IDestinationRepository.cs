using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IDestinationRepository
    {
        IQueryable<IDestination> Destinations { get; }
    }
}