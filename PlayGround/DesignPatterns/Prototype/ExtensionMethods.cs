using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PlayGround.DesignPatterns.Prototype
{
    public static class ExtensionMethods
    {

        public static T DeepCopyExtension<T> (this T self) where T : IPrototype<T>
        {
            var stream = new MemoryStream();
            var fomatter = new BinaryFormatter();
            fomatter.Serialize(stream, self);
            stream.Seek(0, SeekOrigin.Begin);
            object copy = fomatter.Deserialize(stream);

            return (T)copy;

        }

        public static T DeepCopyXmlExtension<T> (this T self)
        {
 
            using(var stream = new MemoryStream())            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stream, self);
                stream.Position=0;
                return (T)serializer.Deserialize(stream);
            }
          
        }
    }
}
