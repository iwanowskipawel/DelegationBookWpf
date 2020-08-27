using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private DataCollection _context;
        public EmployeeRepository(DataCollection context)
        {
            _context = context;
        }
        public IQueryable<IEmployee> Employees => _context.Employees;
    }
}
