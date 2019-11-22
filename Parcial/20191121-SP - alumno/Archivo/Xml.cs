using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivo
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoritPath
        {
            get
            {
                string escritorio = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\";
                return escritorio;
            }
        }

        public bool FileExists(string nombrearchivo)
        {
            try
            {
                string archivo = $"{GetDirectoritPath}\\{nombrearchivo}";
                new XmlTextReader(archivo);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public void Guardar(string nombrearchivo, T objeto)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(nombrearchivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("No se encontro el archivo", ex);
            }
            finally
            {
                if (!(writer is null))
                {
                    writer.Close();
                }
            }

        }
        public void Guardar(string nombrearchivo, T objeto, Encoding encoding)
        {
            XmlTextWriter writer = null;
            XmlSerializer ser;

            try
            {
                writer = new XmlTextWriter(nombrearchivo, encoding);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
            }
            catch (Exception ex)
            {
                throw new ErrorArchivoException("No se encontro el archivo", ex);
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
            XmlTextReader reader = null;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(nombrearchivo);
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
        public bool Leer(string nombrearchivo, out T objeto, Encoding encoding)
        {
            XmlTextReader reader = null;
            XmlSerializer ser;

            try
            {
                reader = new XmlTextReader(nombrearchivo);
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
    }
}
