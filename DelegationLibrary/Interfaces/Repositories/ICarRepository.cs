using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface ICarRepository
    {
        IQueryable<ICar> Cars { get; }
    }
}