using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class ArchivosExcepcion : Exception
    {
        public ArchivosExcepcion(Exception innerException) : base(innerException.Message,innerException)
        {

        }
    }
}
