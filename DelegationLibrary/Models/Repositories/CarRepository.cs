using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class CarRepository : ICarRepository
    {
        private DataCollection _context;
        public CarRepository(DataCollection context)
        {
            _context = context;
        }
        public IQueryable<ICar> Cars => _context.Cars;
    }
}
