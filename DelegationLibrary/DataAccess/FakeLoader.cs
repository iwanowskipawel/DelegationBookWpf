using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public class FakeLoader : IDataLoader
    {
        public DataCollection LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
