using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Entidades
{
    public class SerializarXml<T> : IArchivos<T>
    {
        
        public bool Guardar(string rutaArchivo, T objeto)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(writer, objeto);
                writer.Close();

                return true;
            }
            catch (Exception e)
            {
                throw new ErrorArchivoExcepcion("Error al guardar el archivo");
            }
        }

        
        public T Leer(string rutaArchivo)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(rutaArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));

               reader.Close();
               return (T)ser.Deserialize(reader);
            }
            catch (Exception e)
            {
                throw new ErrorArchivoExcepcion("Error al leer el archivo");
            }

        }
    }
}
