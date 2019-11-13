using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Negocio
{
    public class Negocio
    {
        Caja caja1;
        Caja caja2;
        public List<string> clientes;

        public Negocio(Caja caja1, Caja caja2)
        {
            this.caja1 = caja1;
            this.caja2 = caja2;
            clientes = new List<string>();
        }

        public Caja Caja1
        {
            get
            {
                return this.caja1;
            }
        }
        public Caja Caja2
        {
            get
            {
                return this.caja2;
            }
        }
        public List<string> Clientes
        {
            get
            {
                return this.clientes;
            }
        }

        public void AsignarCaja()
        {
            Console.WriteLine("Asiganando cajas...");

            foreach (string item in this.clientes)
            {
                if (caja1.FilaClientes.Count <= caja2.FilaClientes.Count)
                {
                    caja1.filaClientes.Add(item);
                }
                else
                {
                    caja2.filaClientes.Add(item);
                }
                System.Threading.Thread.Sleep(1000);
            }

        }


    }
}
