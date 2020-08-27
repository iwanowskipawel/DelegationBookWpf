using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class AddressRepository : IAddressRepository
    {
        private ApplicationDbContext _context;
        public AddressRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IAddress> Addresses => _context.Addresses;
    }
}
