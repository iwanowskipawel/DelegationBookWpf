using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class KilometersCardRepository : IKilometersCardRepository
    {
        private ApplicationDbContext _context;
        public KilometersCardRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public IQueryable<IKilometersCard> KilometersCards => _context.KilometersCards;
    }
}
