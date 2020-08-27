using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class DriverRepository
    {
        private ApplicationDbContext _context;
        public DriverRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IDriver> Drivers => _context.Drivers;
    }
}
