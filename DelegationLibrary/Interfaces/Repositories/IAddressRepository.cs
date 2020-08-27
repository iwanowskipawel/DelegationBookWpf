using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IAddressRepository
    {
        IQueryable<IAddress> Addresses { get; }
    }
}