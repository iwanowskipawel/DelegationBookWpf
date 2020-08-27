using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class ProjectRepository : IProjectRepository
    {
        private ApplicationDbContext _context;
        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IProject> Projects => _context.Projects;
    }
}
