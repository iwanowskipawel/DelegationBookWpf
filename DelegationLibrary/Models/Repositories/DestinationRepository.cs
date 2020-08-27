using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class DestinationRepository : IDestinationRepository
    {
        private ApplicationDbContext _context;
        public DestinationRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IDestination> Destinations => _context.Destinations;
    }
}
