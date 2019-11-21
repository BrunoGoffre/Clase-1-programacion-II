using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Probando_cosas
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter writer = new StreamWriter("bitacora.txt"))
            {
                writer.Write("Palabra ");
                writer.WriteLine("Otras Palabras");
                writer.WriteLine("Línea");
            }

            

        }
    }
}
