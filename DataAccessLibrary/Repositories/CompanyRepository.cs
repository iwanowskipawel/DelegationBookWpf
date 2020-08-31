using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class CompanyRepository : ICompanyRepository
    {
        private DataCollection _context;
        public CompanyRepository(DataCollection context)
        {
            _context = context;
        }
        public IEnumerable<ICompany> Companies => _context.Companies;
    }
}
