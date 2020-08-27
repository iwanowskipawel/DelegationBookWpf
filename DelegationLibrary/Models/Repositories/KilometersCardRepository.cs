using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class KilometersCardRepository : IKilometersCardRepository
    {
        private DataCollection _context;
        public KilometersCardRepository(DataCollection context)
        {
            _context = context;
        }
        public IQueryable<IKilometersCard> KilometersCards => _context.KilometersCards;
    }
}
