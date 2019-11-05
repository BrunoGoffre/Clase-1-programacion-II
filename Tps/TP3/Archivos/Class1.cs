using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public interface IArchivos<T>
    {
        public bool Guarda(string archivo, T datos);
        public bool Leer(string archivo, out T datos);
    }
}
