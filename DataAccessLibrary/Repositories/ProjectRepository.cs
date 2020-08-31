using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class ProjectRepository : IProjectRepository
    {
        private DataCollection _context;
        public ProjectRepository(DataCollection context)
        {
            _context = context;
        }
        public IEnumerable<IProject> Projects => _context.Projects;
    }
}
