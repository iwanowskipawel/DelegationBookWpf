using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class BusinessTripRepository
    {
        private ApplicationDbContext _context;
        public BusinessTripRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IBusinessTrip> BusinessTrip => _context.BusinessTrips;
    }
}
