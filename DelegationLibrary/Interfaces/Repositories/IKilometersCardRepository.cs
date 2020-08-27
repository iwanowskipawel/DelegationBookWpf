using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IKilometersCardRepository
    {
        IQueryable<IKilometersCard> KilometersCards { get; }
    }
}