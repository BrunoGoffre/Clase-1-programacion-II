using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Negocio
{
    class Program
    {
        static void Main(string[] args)
        {
            Caja caja1 = new Caja();
            Caja caja2 = new Caja();
            Negocio mac = new Negocio(caja1, caja2);
            Thread hiloCaja1 = new Thread(caja1.AtenderClientes);
            Thread hiloCaja2 = new Thread(caja2.AtenderClientes);
            Thread Asignador = new Thread(mac.AsignarCaja);

            hiloCaja1.Name = "Caja1";
            hiloCaja2.Name = "Caja2";

            string[] array = new string[10];

            array[0] = "Bruno";
            array[1] = "Ruben";
            array[2] = "Marian";
            array[3] = "Rodrigo";
            array[4] = "Juan";
            array[5] = "Pepe";
            array[6] = "Maria";
            array[7] = "Marina";
            array[8] = "Juan";
            array[9] = "Federico";
            foreach (string item in array)
            {
                mac.clientes.Add(item);
            }

            Asignador.Start();
            Asignador.Join();
            hiloCaja1.Start();
            hiloCaja2.Start();

            Console.ReadKey();


        }
    }
}
