using DelegationLibrary.DataAccess;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataAccessLibrary.DataAccess
{
    public class ObjectLoader : IDataLoader
    {
        string _path = "";
        public ObjectLoader(string path)
        {
            _path = path;
        }

        public IDataCollection Load()
        {
            IDataCollection output = new DataCollection();
            try
            {
                using (FileStream f = File.Open(_path, FileMode.OpenOrCreate))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    output = (DataCollection)b.Deserialize(f);
                    f.Close();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Wystąpił błąd w trakcie wczytywania pliku.", ex);
            }

            return output;
        }

        public bool Save(IDataCollection collection)
        {
            bool success = false;
            //try
            //{
                using (FileStream f = File.Open(_path, FileMode.OpenOrCreate))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(f, collection);
                    f.Close();
                    success = true;
                }
            //}
            //catch(Exception ex)
            //{
            //    throw new Exception("Wystąpił błąd w trakcie zapisywania pliku.", ex);
            //}

            return success;
        }
    }
}
