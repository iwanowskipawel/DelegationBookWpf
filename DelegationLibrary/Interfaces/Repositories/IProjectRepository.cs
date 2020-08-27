using DelegationLibrary.Model;
using System.Collections.Generic;
using System.Linq;

namespace DelegationLibrary.DataAccess
{
    public interface IProjectRepository
    {
        IEnumerable<IProject> Projects { get; }
    }
}