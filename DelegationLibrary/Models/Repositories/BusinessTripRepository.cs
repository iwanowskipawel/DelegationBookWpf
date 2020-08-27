using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class BusinessTripRepository : IBusinessTripRepository
    {
        private DataCollection _context;
        public BusinessTripRepository(DataCollection context)
        {
            _context = context;
        }
        public IEnumerable<IBusinessTrip> BusinessTrip => _context.BusinessTrips;
    }
}
