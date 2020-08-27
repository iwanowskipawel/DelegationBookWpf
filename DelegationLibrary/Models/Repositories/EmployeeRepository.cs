using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private ApplicationDbContext _context;
        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IEmployee> Employees => _context.Employees;
    }
}
