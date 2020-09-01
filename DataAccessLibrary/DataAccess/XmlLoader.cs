using DelegationLibrary.DataAccess;
using DelegationLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DataAccessLibrary.DataAccess
{
    public class XmlLoader : IDataLoader
    {
        string _path;

        public XmlLoader(string filePath)
        {
            _path = filePath;
        }

        public IDataCollection Load()
        {
            DataCollection output = new DataCollection();

            XmlSerializer serializer = new XmlSerializer(typeof(DataCollection));
            using (FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                StreamReader reader = new StreamReader(fileStream);
                output = (DataCollection)serializer.Deserialize(reader);
            }
            return output;
        }

        public bool Save(IDataCollection collection)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(KilometersCard));
            FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);


            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, collection);
                    var xml = sww.ToString();
                    streamWriter.Write(xml);
                    fileStream.Close();
                }
            }
            return true;
        }
    }
}
