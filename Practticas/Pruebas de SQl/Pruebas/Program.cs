using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pruebas_de_SQl;
namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 clase = new Class1();
            List<Class2> entregas = new List<Class2>();

            entregas = clase.MethodSql(entregas);

            foreach  (Class2 item in entregas)
            {
                Console.WriteLine(item.id + " " +  item.nombre);
            }

            bool boleano = true;
            string cadena = boleano.EstadoSimulacion();



            //Console.WriteLine(Class1.NuevoMEtodo());
            //Console.WriteLine(Class1.OtroMetodo());
            Console.ReadKey();
        }
    }
}
