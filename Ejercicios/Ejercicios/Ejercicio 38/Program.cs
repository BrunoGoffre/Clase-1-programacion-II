using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nº38 Guía 2017";
            SobreSobreEscrito sobrecarga = new SobreSobreEscrito();
            Console.WriteLine(sobrecarga.MiMetodo());            
            Console.ReadKey();

        }
    }
}
