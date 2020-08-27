using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public static class DataAccess
    {
        public static DataCollection GetCollection(IDataLoader loader) => loader.LoadData();
    }
}
