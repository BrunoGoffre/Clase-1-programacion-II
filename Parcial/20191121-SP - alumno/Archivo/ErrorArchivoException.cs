using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivo
{
    public class ErrorArchivoException : Exception
    {
        public ErrorArchivoException(string mensaje) : base()
        {

        }
        public ErrorArchivoException(string mensaje, Exception ex) : base(mensaje,ex.InnerException)
        {

        }

    }
}
