using System;
using System.Collections.Generic;
using System.Text;

namespace DelegationLibrary.DataAccess
{
    public static class DataAccess
    {
        public static IDataCollection GetCollection(IDataLoader loader) => loader.Load();
        public static bool SaveCollection(IDataCollection collection, IDataLoader loader) => loader.Save(collection);
    }
}
