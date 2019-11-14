using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ErrorArchivoExcepcion : Exception
    {
        public ErrorArchivoExcepcion(string mensaje) : base(mensaje)
        {

        }
    }
}
