using DelegationLibrary.DataAccess;
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

        public IDataCollection LoadData()
        {
            IDataCollection output = new DataCollection();


            return output;
        }

        public bool SaveData(DataCollection collection)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(DataCollection));
            FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, collection);
                    xml = sww.ToString();
                    streamWriter.Write(xml);
                    fileStream.Close();
                }
            }
            return true;
        }
    }
}
