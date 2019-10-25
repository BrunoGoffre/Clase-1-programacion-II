using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42_Biblioteca
{
    public class UnaEsepcion : Exception
    {
        public UnaEsepcion()
        {

        }
        public UnaEsepcion(string mensaje) : base(mensaje)
        {

        }
        public UnaEsepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
