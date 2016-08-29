using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PickleDotNet
{
    public class Pickle<E>
    {
        public void Dump(E Data, String path)
        {
            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(E));
            System.IO.FileStream file = System.IO.File.Create(path);

            writer.Serialize(file, Data);
            file.Close();
        }

        public void Load(String path)
        {
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(E));
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            E output = (E)reader.Deserialize(file);
            file.Close();
        }
    }
}
