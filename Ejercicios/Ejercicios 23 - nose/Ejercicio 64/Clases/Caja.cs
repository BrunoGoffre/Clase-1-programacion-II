using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Negocio
{
    public class Caja
    {
        public List<string> filaClientes;

        public List<string> FilaClientes
        {
            get
            {
                return this.filaClientes;
            }
        }

        public void AtenderClientes()
        {
            foreach (string item in filaClientes)
            {
                
                Console.WriteLine(Thread.CurrentThread.Name  + " = " + item);
                System.Threading.Thread.Sleep(2000);
            }
        }
        public Caja()
        {
            this.filaClientes = new List<string>();
        }
    }
}
