using DelegationLibrary.Model;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IProjectRepository
    {
        IQueryable<IProject> Projects { get; }
    }
}