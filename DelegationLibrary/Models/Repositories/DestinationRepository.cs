using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class DestinationRepository : IDestinationRepository
    {
        private DataCollection _context;
        public DestinationRepository(DataCollection context)
        {
            _context = context;
        }
        public IEnumerable<IDestination> Destinations => _context.Destinations;
    }
}
