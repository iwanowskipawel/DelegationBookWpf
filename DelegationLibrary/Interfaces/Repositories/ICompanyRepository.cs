using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface ICompanyRepository
    {
        IQueryable<ICompany> Companies { get; }
    }
}