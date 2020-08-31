using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class AddressRepository : IAddressRepository
    {
        private DataCollection _context;
        public AddressRepository(DataCollection context)
        {
            _context = context;
        }
        public IEnumerable<IAddress> Addresses => _context.Addresses;
    }
}
