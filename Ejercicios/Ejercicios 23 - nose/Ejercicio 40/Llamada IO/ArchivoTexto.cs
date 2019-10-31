using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio_54
{
    public static class ArchivoTexto
    {
        public static bool Save(string path, string info)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"D:\bg\\{path}");
            StreamWriter sw = new StreamWriter(sb.ToString());
            if (sw != null)
            {
                sw.WriteLine(info);
            }
            return true;
        }
        public static string Read(string path)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"D:\bg\\{path}");

            if (File.Exists(sb.ToString()))
            {
                StreamReader sr = new StreamReader(sb.ToString());
                return sr.ReadToEnd();
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
