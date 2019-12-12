using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Archivo
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }

        public bool FileExists(string nombrearchivo)
        {
            return File.Exists(this.Path(nombrearchivo));
        }
        public void Guardar(string nombrearchivo, T objeto)
        {
            this.Guardar(nombrearchivo,objeto,Encoding.UTF8);
        }
        public void Guardar(string nombrearchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(this.Path(nombrearchivo), encoding);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException(ex.Message, ex);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                }
            }
        }
        public bool Leer(string nombrearchivo, out T objeto)
        {
            return this.Leer(nombrearchivo, out objeto, Encoding.UTF8);
        }
        public bool Leer(string nombrearchivo, out T objeto, Encoding encoding)
        {
            XmlTextReader reader = null;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(this.Path(nombrearchivo) + nombrearchivo);
                ser = new XmlSerializer(typeof(T));
                objeto = (T)ser.Deserialize(reader);
                return true;
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("No se encontro el archivo", ex);
            }
            finally
            {
                if (!(reader is null))
                {
                    reader.Close();
                }
            }
        }
        public string Path(string nombreArchivo)
        {
            string path = $"{this.GetDirectoryPath}\\c{nombreArchivo}";
            return path;
        }
    }
}
