using System;
using System.IO;
using System.Xml.Serialization;
using DomainPro.Core.Types;
using DomainPro.Core.Interfaces;
using DomainPro.Designer.Types;
using DomainPro.Designer.Interfaces;
using Designer.Types;

namespace Designer.Factories
{
    public class CollabArchV6ModelFactory : DP_IModelFactory
    {
        public DP_AbstractModelType CreateModel()
        {
            return new CollabArchV6Model("NewCollabArchV6");
        }

        public void SaveModel(DP_AbstractModelType model, string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CollabArchV6Model));
            TextWriter textWriter = new StreamWriter(path);
            serializer.Serialize(textWriter, model);
            textWriter.Close();
        }

        public DP_AbstractModelType LoadModel(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(CollabArchV6Model));
            TextReader textReader = new StreamReader(path);
            CollabArchV6Model model = (CollabArchV6Model)deserializer.Deserialize(textReader);
            textReader.Close();
            return model;
        }
    }
}
